namespace ETWDeserializer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;

    internal static class EventTraceOperandExpressionBuilder
    {
        public static Expression Build(
            IEventTraceOperand operand,
            ParameterExpression eventRecordReader,
            ParameterExpression eventRecordWriter,
            ParameterExpression eventMetadataTable,
            ParameterExpression runtimeMetadata)
        {
            return new EventTraceOperandExpressionBuilderImpl().Build(operand, eventRecordReader, eventRecordWriter, eventMetadataTable, runtimeMetadata);
        }

        public static MethodCallExpression Call(this ParameterExpression instance, string methodName, params Expression[] arguments)
        {
            Type[] parameterTypes = arguments.Select(t => t.Type).ToArray();
            var methodInfo = instance.Type.GetMethod(methodName, parameterTypes);
            return Expression.Call(instance, methodInfo, arguments);
        }
    }

    internal sealed class EventTraceOperandExpressionBuilderImpl
    {
        public Expression Build(IEventTraceOperand operand, ParameterExpression eventRecordReader, ParameterExpression eventRecordWriter, ParameterExpression eventMetadataTable, ParameterExpression runtimeMetadata)
        {
            var eventMetadata = Expression.Parameter(typeof(EventMetadata));
            var properties = Expression.Parameter(typeof(PropertyMetadata[]));

            var variables = new List<ParameterExpression>
            {
                eventMetadata,
                properties
            };

            var expGenerator = new ExpressionGenerator(eventRecordReader, eventRecordWriter, properties);
            var list = new List<Expression>
            {
                Expression.Assign(eventMetadata, Expression.ArrayAccess(eventMetadataTable, Expression.Constant(operand.EventMetadataTableIndex))),
                Expression.Assign(properties, Expression.PropertyOrField(eventMetadata, "Properties")),
                eventRecordWriter.Call("WriteEventBegin", eventMetadata, runtimeMetadata),
                expGenerator.CodeGenerate(operand.EventPropertyOperands),
                eventRecordWriter.Call("WriteEventEnd")
            };

            var returnExpression = Expression.Block(variables, list);
            return returnExpression;
        }

        private sealed class ExpressionGenerator
        {
            private readonly Dictionary<IEventTracePropertyOperand, Expression> operandReferenceTable = new Dictionary<IEventTracePropertyOperand, Expression>();

            private readonly ParameterExpression eventRecordReader;

            private readonly ParameterExpression eventRecordWriter;

            private readonly ParameterExpression properties;

            public ExpressionGenerator(ParameterExpression eventRecordReader, ParameterExpression eventRecordWriter, ParameterExpression properties)
            {
                this.eventRecordReader = eventRecordReader;
                this.eventRecordWriter = eventRecordWriter;
                this.properties = properties;
            }

            public Expression CodeGenerate(IEnumerable<IEventTracePropertyOperand> operands)
            {
                var variables = new List<ParameterExpression>();
                var list = new List<Expression>();

                foreach (var operand in operands)
                {
                    var inType = operand.Metadata.InType;
                    Expression c; /* running expression for this operand */

                    list.Add(this.eventRecordWriter.Call("WritePropertyBegin", Expression.ArrayAccess(this.properties, Expression.Constant(operand.PropertyIndex))));

                    /* if struct, recurse */
                    if (operand.Children.Count > 0)
                    {
                        c = Expression.Block(
                            this.eventRecordWriter.Call("WriteStructBegin"),
                            this.CodeGenerate(operand.Children),
                            this.eventRecordWriter.Call("WriteStructEnd"));
                    }
                    else
                    {
                        Expression readValue;

                        /* otherwise, if operand has a length parameter, look it up or make constant */
                        if (operand.IsVariableLength || operand.IsFixedLength)
                        {
                            var length = operand.IsVariableLength
                                ? this.operandReferenceTable[operand.VariableLengthSize]
                                : Expression.Constant(operand.FixedLengthSize);

                            readValue = Call(this.eventRecordReader, inType.ReadMethodInfo(this.eventRecordReader.Type, length.Type), length);
                        }

                        /* otherwise, it's just a normal call, no args */
                        else
                        {
                            readValue = Call(this.eventRecordReader, inType.ReadMethodInfo(this.eventRecordReader.Type));
                        }

                        /* save the operand because someone else maybe needing it */
                        /* and change the running variable */
                        if (operand.IsReferencedByOtherProperties)
                        {
                            var local = Expression.Parameter(inType.CSharpType(), operand.Metadata.Name);
                            this.operandReferenceTable.Add(operand, local);
                            variables.Add(local);
                            c = Expression.Block(Expression.Assign(local, readValue), Call(this.eventRecordWriter, inType.WriteMethodInfo(this.eventRecordWriter.Type, local.Type), local));
                        }
                        else
                        {
                            c = Call(this.eventRecordWriter, inType.WriteMethodInfo(this.eventRecordWriter.Type, inType.CSharpType()), readValue);
                        }
                    }

                    if (operand.IsVariableArray || operand.IsFixedArray)
                    {
                        var loopVariable = Expression.Parameter(typeof(int));
                        variables.Add(loopVariable);

                        var end = operand.IsVariableArray
                            ? this.operandReferenceTable[operand.VariableArraySize]
                            : Expression.Constant(operand.FixedArraySize);

                        var expr = (Expression)loopVariable;
                        ConvertIfNecessary(ref expr, ref end);
                        list.Add(this.eventRecordWriter.Call("WriteArrayBegin"));
                        list.Add(For(loopVariable, Expression.Constant(0), Expression.LessThan(expr, end), Expression.AddAssign(loopVariable, Expression.Constant(1)), c));
                        list.Add(this.eventRecordWriter.Call("WriteArrayEnd"));
                    }
                    else
                    {
                        list.Add(c);
                    }

                    list.Add(this.eventRecordWriter.Call("WritePropertyEnd"));
                }

                return list.Count == 0 ? (Expression)Expression.Empty() : Expression.Block(variables, list);
            }

            private static MethodCallExpression Call(ParameterExpression instance, MethodInfo methodInfo, params Expression[] arguments)
            {
                return Expression.Call(instance, methodInfo, arguments);
            }

            private static Expression For(ParameterExpression parameter, Expression initial, Expression condition, Expression increment, params Expression[] body)
            {
                var breakLabel = Expression.Label("break");
                var loop = Expression.Block(
                    new[] { parameter },
                    Expression.Assign(parameter, initial),
                    Expression.Loop(
                        Expression.IfThenElse(
                            condition,
                            Expression.Block(
                                body.Concat(new[] { increment })),
                            Expression.Break(breakLabel)),
                        breakLabel));

                return loop;
            }

            private static void ConvertIfNecessary(ref Expression left, ref Expression right)
            {
                var leftTypeCode = Type.GetTypeCode(left.Type);
                var rightTypeCode = Type.GetTypeCode(right.Type);

                if (leftTypeCode == rightTypeCode)
                {
                    return;
                }

                if (leftTypeCode > rightTypeCode)
                {
                    right = Expression.Convert(right, left.Type);
                }
                else
                {
                    left = Expression.Convert(left, right.Type);
                }
            }
        }
    }
}