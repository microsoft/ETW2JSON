[assembly:System.Security.AllowPartiallyTrustedCallers()]
[assembly:System.Security.SecurityTransparent()]
[assembly:System.Security.SecurityRules(System.Security.SecurityRuleSet.Level1)]
[assembly:System.Xml.Serialization.XmlSerializerVersionAttribute(ParentAssemblyId=@"720d317a-bb51-42be-b5d5-2936f41e9400,", Version=@"1.0.0.0")]
namespace Microsoft.Xml.Serialization.GeneratedAssembly {

    public class XmlSerializationWriter1 : System.Xml.Serialization.XmlSerializationWriter {

        public void Write68_instrumentationManifest(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"instrumentationManifest", @"http://schemas.microsoft.com/win/2004/08/events");
                return;
            }
            TopLevelElement();
            Write55_instrumentationManifest(@"instrumentationManifest", @"http://schemas.microsoft.com/win/2004/08/events", ((global::instrumentationManifest)o), false, false);
        }

        public void Write69_InstrumentationType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"InstrumentationType", @"");
                return;
            }
            TopLevelElement();
            Write43_InstrumentationType(@"InstrumentationType", @"", ((global::InstrumentationType)o), true, false);
        }

        public void Write70_events(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"events", @"http://schemas.microsoft.com/win/2004/08/events");
                return;
            }
            TopLevelElement();
            Write42_EventsType(@"events", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventsType)o), false, false);
        }

        public void Write71_EventsTypeMessageTable(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"EventsTypeMessageTable", @"");
                return;
            }
            TopLevelElement();
            Write56_EventsTypeMessageTable(@"EventsTypeMessageTable", @"", ((global::EventsTypeMessageTable)o), true, false);
        }

        public void Write72_EventsTypeMessageTableMessage(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"EventsTypeMessageTableMessage", @"");
                return;
            }
            TopLevelElement();
            Write57_EventsTypeMessageTableMessage(@"EventsTypeMessageTableMessage", @"", ((global::EventsTypeMessageTableMessage)o), true, false);
        }

        public void Write73_StringTableType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"StringTableType", @"");
                return;
            }
            TopLevelElement();
            Write45_StringTableType(@"StringTableType", @"", ((global::StringTableType)o), true, false);
        }

        public void Write74_StringTableTypeString(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"StringTableTypeString", @"");
                return;
            }
            TopLevelElement();
            Write58_StringTableTypeString(@"StringTableTypeString", @"", ((global::StringTableTypeString)o), true, false);
        }

        public void Write75_LocalizationType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LocalizationType", @"");
                return;
            }
            TopLevelElement();
            Write47_LocalizationType(@"LocalizationType", @"", ((global::LocalizationType)o), true, false);
        }

        public void Write76_LocalizationTypeResources(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LocalizationTypeResources", @"");
                return;
            }
            TopLevelElement();
            Write59_LocalizationTypeResources(@"LocalizationTypeResources", @"", ((global::LocalizationTypeResources)o), true, false);
        }

        public void Write77_FilterType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"FilterType", @"");
                return;
            }
            TopLevelElement();
            Write16_FilterType(@"FilterType", @"", ((global::FilterType)o), true, false);
        }

        public void Write78_FilterListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"FilterListType", @"");
                return;
            }
            TopLevelElement();
            Write17_FilterListType(@"FilterListType", @"", ((global::FilterListType)o), true, false);
        }

        public void Write79_DefinitionType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DefinitionType", @"");
                return;
            }
            TopLevelElement();
            Write15_DefinitionType(@"DefinitionType", @"", ((global::DefinitionType)o), true, false);
        }

        public void Write80_EventDefinitionType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"EventDefinitionType", @"");
                return;
            }
            TopLevelElement();
            Write14_EventDefinitionType(@"EventDefinitionType", @"", ((global::EventDefinitionType)o), true, false);
        }

        public void Write81_TemplateListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TemplateListType", @"");
                return;
            }
            TopLevelElement();
            Write39_TemplateListType(@"TemplateListType", @"", ((global::TemplateListType)o), true, false);
        }

        public void Write82_TemplateItemType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TemplateItemType", @"");
                return;
            }
            TopLevelElement();
            Write38_TemplateItemType(@"TemplateItemType", @"", ((global::TemplateItemType)o), true, false);
        }

        public void Write83_DataDefinitionType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"DataDefinitionType", @"");
                return;
            }
            TopLevelElement();
            Write34_DataDefinitionType(@"DataDefinitionType", @"", ((global::DataDefinitionType)o), true, false);
        }

        public void Write84_StructDefinitionType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"StructDefinitionType", @"");
                return;
            }
            TopLevelElement();
            Write35_StructDefinitionType(@"StructDefinitionType", @"", ((global::StructDefinitionType)o), true, false);
        }

        public void Write85_TemplateItemTypeBinary(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TemplateItemTypeBinary", @"");
                return;
            }
            TopLevelElement();
            Write60_TemplateItemTypeBinary(@"TemplateItemTypeBinary", @"", ((global::TemplateItemTypeBinary)o), true, false);
        }

        public void Write86_XmlType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlType", @"");
                return;
            }
            TopLevelElement();
            Write37_XmlType(@"XmlType", @"", ((global::XmlType)o), true, false);
        }

        public void Write87_MapType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"MapType", @"");
                return;
            }
            TopLevelElement();
            Write26_MapType(@"MapType", @"", ((global::MapType)o), true, false);
        }

        public void Write88_BitMapType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"BitMapType", @"");
                return;
            }
            TopLevelElement();
            Write23_BitMapType(@"BitMapType", @"", ((global::BitMapType)o), true, false);
        }

        public void Write89_BitMapValueType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"BitMapValueType", @"");
                return;
            }
            TopLevelElement();
            Write22_BitMapValueType(@"BitMapValueType", @"", ((global::BitMapValueType)o), true, false);
        }

        public void Write90_ValueMapType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ValueMapType", @"");
                return;
            }
            TopLevelElement();
            Write25_ValueMapType(@"ValueMapType", @"", ((global::ValueMapType)o), true, false);
        }

        public void Write91_ValueMapValueType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ValueMapValueType", @"");
                return;
            }
            TopLevelElement();
            Write24_ValueMapValueType(@"ValueMapValueType", @"", ((global::ValueMapValueType)o), true, false);
        }

        public void Write92_ProviderType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ProviderType", @"");
                return;
            }
            TopLevelElement();
            Write41_ProviderType(@"ProviderType", @"", ((global::ProviderType)o), true, false);
        }

        public void Write93_ChannelListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ChannelListType", @"");
                return;
            }
            TopLevelElement();
            Write13_ChannelListType(@"ChannelListType", @"", ((global::ChannelListType)o), true, false);
        }

        public void Write94_ChannelType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ChannelType", @"");
                return;
            }
            TopLevelElement();
            Write11_ChannelType(@"ChannelType", @"", ((global::ChannelType)o), true, false);
        }

        public void Write95_ChannelLoggingType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ChannelLoggingType", @"");
                return;
            }
            TopLevelElement();
            Write5_ChannelLoggingType(@"ChannelLoggingType", @"", ((global::ChannelLoggingType)o), true, false);
        }

        public void Write96_ChannelPublishingType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ChannelPublishingType", @"");
                return;
            }
            TopLevelElement();
            Write8_ChannelPublishingType(@"ChannelPublishingType", @"", ((global::ChannelPublishingType)o), true, false);
        }

        public void Write97_ChannelPublishingTypeClockType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"ChannelPublishingTypeClockType", @"");
                return;
            }
            WriteElementString(@"ChannelPublishingTypeClockType", @"", Write61_ChannelPublishingTypeClockType(((global::ChannelPublishingTypeClockType)o)));
        }

        public void Write98_ChannelPublishingTypeSidType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"ChannelPublishingTypeSidType", @"");
                return;
            }
            WriteElementString(@"ChannelPublishingTypeSidType", @"", Write62_ChannelPublishingTypeSidType(((global::ChannelPublishingTypeSidType)o)));
        }

        public void Write99_ChannelTypeType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"ChannelTypeType", @"");
                return;
            }
            WriteElementString(@"ChannelTypeType", @"", Write63_ChannelTypeType(((global::ChannelTypeType)o)));
        }

        public void Write100_ChannelTypeIsolation(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"ChannelTypeIsolation", @"");
                return;
            }
            WriteElementString(@"ChannelTypeIsolation", @"", Write64_ChannelTypeIsolation(((global::ChannelTypeIsolation)o)));
        }

        public void Write101_ImportChannelType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"ImportChannelType", @"");
                return;
            }
            TopLevelElement();
            Write12_ImportChannelType(@"ImportChannelType", @"", ((global::ImportChannelType)o), true, false);
        }

        public void Write102_KeywordListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"KeywordListType", @"");
                return;
            }
            TopLevelElement();
            Write19_KeywordListType(@"KeywordListType", @"", ((global::KeywordListType)o), true, false);
        }

        public void Write103_KeywordType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"KeywordType", @"");
                return;
            }
            TopLevelElement();
            Write18_KeywordType(@"KeywordType", @"", ((global::KeywordType)o), true, false);
        }

        public void Write104_LevelListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LevelListType", @"");
                return;
            }
            TopLevelElement();
            Write21_LevelListType(@"LevelListType", @"", ((global::LevelListType)o), true, false);
        }

        public void Write105_LevelType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"LevelType", @"");
                return;
            }
            TopLevelElement();
            Write20_LevelType(@"LevelType", @"", ((global::LevelType)o), true, false);
        }

        public void Write106_NamedQueryType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"NamedQueryType", @"");
                return;
            }
            TopLevelElement();
            Write29_NamedQueryType(@"NamedQueryType", @"", ((global::NamedQueryType)o), true, false);
        }

        public void Write107_PatternMapType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PatternMapType", @"");
                return;
            }
            TopLevelElement();
            Write28_PatternMapType(@"PatternMapType", @"", ((global::PatternMapType)o), true, false);
        }

        public void Write108_PatternMapValueType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"PatternMapValueType", @"");
                return;
            }
            TopLevelElement();
            Write27_PatternMapValueType(@"PatternMapValueType", @"", ((global::PatternMapValueType)o), true, false);
        }

        public void Write109_OpcodeListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"OpcodeListType", @"");
                return;
            }
            TopLevelElement();
            Write31_OpcodeListType(@"OpcodeListType", @"", ((global::OpcodeListType)o), true, false);
        }

        public void Write110_OpcodeType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"OpcodeType", @"");
                return;
            }
            TopLevelElement();
            Write30_OpcodeType(@"OpcodeType", @"", ((global::OpcodeType)o), true, false);
        }

        public void Write111_TaskListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TaskListType", @"");
                return;
            }
            TopLevelElement();
            Write33_TaskListType(@"TaskListType", @"", ((global::TaskListType)o), true, false);
        }

        public void Write112_TaskType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"TaskType", @"");
                return;
            }
            TopLevelElement();
            Write32_TaskType(@"TaskType", @"", ((global::TaskType)o), true, false);
        }

        public void Write113_ProviderTypeSource(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteEmptyTag(@"ProviderTypeSource", @"");
                return;
            }
            WriteElementString(@"ProviderTypeSource", @"", Write65_ProviderTypeSource(((global::ProviderTypeSource)o)));
        }

        public void Write114_InputTypeListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"InputTypeListType", @"");
                return;
            }
            TopLevelElement();
            Write50_InputTypeListType(@"InputTypeListType", @"", ((global::InputTypeListType)o), true, false);
        }

        public void Write115_InputType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"InputType", @"");
                return;
            }
            TopLevelElement();
            Write49_InputType(@"InputType", @"", ((global::InputType)o), true, false);
        }

        public void Write116_OutputType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"OutputType", @"");
                return;
            }
            TopLevelElement();
            Write48_OutputType(@"OutputType", @"", ((global::OutputType)o), true, false);
        }

        public void Write117_XmlTypeListType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlTypeListType", @"");
                return;
            }
            TopLevelElement();
            Write52_XmlTypeListType(@"XmlTypeListType", @"", ((global::XmlTypeListType)o), true, false);
        }

        public void Write118_XmlTypeListTypeXmlType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"XmlTypeListTypeXmlType", @"");
                return;
            }
            TopLevelElement();
            Write66_XmlTypeListTypeXmlType(@"XmlTypeListTypeXmlType", @"", ((global::XmlTypeListTypeXmlType)o), true, false);
        }

        public void Write119_MetadataType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"MetadataType", @"");
                return;
            }
            TopLevelElement();
            Write54_MetadataType(@"MetadataType", @"", ((global::MetadataType)o), true, false);
        }

        public void Write120_MetadataTypeMessage(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"MetadataTypeMessage", @"");
                return;
            }
            TopLevelElement();
            Write67_MetadataTypeMessage(@"MetadataTypeMessage", @"", ((global::MetadataTypeMessage)o), true, false);
        }

        public void Write121_InstrumentationManifestType(object o) {
            WriteStartDocument();
            if (o == null) {
                WriteNullTagLiteral(@"InstrumentationManifestType", @"");
                return;
            }
            TopLevelElement();
            Write2_InstrumentationManifestType(@"InstrumentationManifestType", @"", ((global::InstrumentationManifestType)o), true, false);
        }

        void Write2_InstrumentationManifestType(string n, string ns, global::InstrumentationManifestType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::InstrumentationManifestType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"InstrumentationManifestType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteEndElement(o);
        }

        void Write67_MetadataTypeMessage(string n, string ns, global::MetadataTypeMessage o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MetadataTypeMessage)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MetadataTypeMessage", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"mid", @"", ((global::System.String)o.@mid));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteEndElement(o);
        }

        void Write54_MetadataType(string n, string ns, global::MetadataType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MetadataType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MetadataType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            Write13_ChannelListType(@"channels", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ChannelListType)o.@channels), false, false);
            {
                global::LevelType[] a = (global::LevelType[])((global::LevelType[])o.@levels);
                if (a != null){
                    WriteStartElement(@"levels", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write20_LevelType(@"level", @"http://schemas.microsoft.com/win/2004/08/events", ((global::LevelType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::TaskType[] a = (global::TaskType[])((global::TaskType[])o.@tasks);
                if (a != null){
                    WriteStartElement(@"tasks", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write32_TaskType(@"task", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TaskType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::OpcodeType[] a = (global::OpcodeType[])((global::OpcodeType[])o.@opcodes);
                if (a != null){
                    WriteStartElement(@"opcodes", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write30_OpcodeType(@"opcode", @"http://schemas.microsoft.com/win/2004/08/events", ((global::OpcodeType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::KeywordType[] a = (global::KeywordType[])((global::KeywordType[])o.@keywords);
                if (a != null){
                    WriteStartElement(@"keywords", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write18_KeywordType(@"keyword", @"http://schemas.microsoft.com/win/2004/08/events", ((global::KeywordType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])((global::System.Object[])o.@types);
                if (a != null){
                    WriteStartElement(@"types", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::System.Xml.XmlElement) {
                                if ((((global::System.Xml.XmlElement)ai)) is System.Xml.XmlNode || ((global::System.Xml.XmlElement)ai) == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)((global::System.Xml.XmlElement)ai), @"XmlElement", @"http://schemas.microsoft.com/win/2004/08/events", false, false);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(((global::System.Xml.XmlElement)ai));
                                }
                            }
                            else if (ai is global::InputTypeListType) {
                                Write50_InputTypeListType(@"inTypes", @"http://schemas.microsoft.com/win/2004/08/events", ((global::InputTypeListType)ai), false, false);
                            }
                            else if (ai is global::XmlTypeListType) {
                                Write52_XmlTypeListType(@"xmlTypes", @"http://schemas.microsoft.com/win/2004/08/events", ((global::XmlTypeListType)ai), false, false);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                    WriteEndElement();
                }
            }
            Write29_NamedQueryType(@"namedQueries", @"http://schemas.microsoft.com/win/2004/08/events", ((global::NamedQueryType)o.@namedQueries), false, false);
            {
                global::MetadataTypeMessage[] a = (global::MetadataTypeMessage[])((global::MetadataTypeMessage[])o.@messageTable);
                if (a != null){
                    WriteStartElement(@"messageTable", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write53_MetadataTypeMessage(@"message", @"http://schemas.microsoft.com/win/2004/08/events", ((global::MetadataTypeMessage)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write53_MetadataTypeMessage(string n, string ns, global::MetadataTypeMessage o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MetadataTypeMessage)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"mid", @"", ((global::System.String)o.@mid));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteEndElement(o);
        }

        void Write29_NamedQueryType(string n, string ns, global::NamedQueryType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::NamedQueryType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"NamedQueryType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::PatternMapType[] a = (global::PatternMapType[])((global::PatternMapType[])o.@patternMaps);
                if (a != null){
                    WriteStartElement(@"patternMaps", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write28_PatternMapType(@"patternMap", @"http://schemas.microsoft.com/win/2004/08/events", ((global::PatternMapType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write28_PatternMapType(string n, string ns, global::PatternMapType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PatternMapType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PatternMapType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"format", @"", ((global::System.String)o.@format));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::PatternMapValueType[] a = (global::PatternMapValueType[])o.@map;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write27_PatternMapValueType(@"map", @"http://schemas.microsoft.com/win/2004/08/events", ((global::PatternMapValueType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write27_PatternMapValueType(string n, string ns, global::PatternMapValueType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::PatternMapValueType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"PatternMapValueType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            if ((object)(o.@Value) != null){
                WriteValue(((global::System.String)o.@Value));
            }
            WriteEndElement(o);
        }

        void Write52_XmlTypeListType(string n, string ns, global::XmlTypeListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::XmlTypeListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"XmlTypeListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::XmlTypeListTypeXmlType[] a = (global::XmlTypeListTypeXmlType[])o.@xmlType;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write51_XmlTypeListTypeXmlType(@"xmlType", @"http://schemas.microsoft.com/win/2004/08/events", ((global::XmlTypeListTypeXmlType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write51_XmlTypeListTypeXmlType(string n, string ns, global::XmlTypeListTypeXmlType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::XmlTypeListTypeXmlType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write50_InputTypeListType(string n, string ns, global::InputTypeListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::InputTypeListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"InputTypeListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::InputType[] a = (global::InputType[])o.@inType;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write49_InputType(@"inType", @"http://schemas.microsoft.com/win/2004/08/events", ((global::InputType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write49_InputType(string n, string ns, global::InputType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::InputType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"InputType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteElementString(@"description", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@description));
            {
                global::OutputType[] a = (global::OutputType[])o.@outType;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write48_OutputType(@"outType", @"http://schemas.microsoft.com/win/2004/08/events", ((global::OutputType)a[ia]), false, false);
                    }
                }
            }
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write48_OutputType(string n, string ns, global::OutputType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::OutputType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"OutputType", @"http://schemas.microsoft.com/win/2004/08/events");
            if (o.@defaultSpecified) {
                WriteAttribute(@"default", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@default)));
            }
            WriteAttribute(@"xmlType", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@xmlType)));
            if (o.@defaultSpecified) {
            }
            if ((object)(o.@Value) != null){
                WriteValue(((global::System.String)o.@Value));
            }
            WriteEndElement(o);
        }

        void Write18_KeywordType(string n, string ns, global::KeywordType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::KeywordType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"KeywordType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"mask", @"", ((global::System.String)o.@mask));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write30_OpcodeType(string n, string ns, global::OpcodeType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::OpcodeType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"OpcodeType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"mofValue", @"", ((global::System.String)o.@mofValue));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write32_TaskType(string n, string ns, global::TaskType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TaskType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TaskType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"eventGUID", @"", ((global::System.String)o.@eventGUID));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::OpcodeType[] a = (global::OpcodeType[])((global::OpcodeType[])o.@opcodes);
                if (a != null){
                    WriteStartElement(@"opcodes", @"http://schemas.microsoft.com/win/2004/08/events", null, false);
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write30_OpcodeType(@"opcode", @"http://schemas.microsoft.com/win/2004/08/events", ((global::OpcodeType)a[ia]), false, false);
                    }
                    WriteEndElement();
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write20_LevelType(string n, string ns, global::LevelType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::LevelType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LevelType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write13_ChannelListType(string n, string ns, global::ChannelListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ChannelListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChannelListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::ImportChannelType) {
                                Write12_ImportChannelType(@"importChannel", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ImportChannelType)ai), false, false);
                            }
                            else if (ai is global::ChannelType) {
                                Write11_ChannelType(@"channel", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ChannelType)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write11_ChannelType(string n, string ns, global::ChannelType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ChannelType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChannelType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"chid", @"", ((global::System.String)o.@chid));
            WriteAttribute(@"type", @"", Write9_ChannelTypeType(((global::ChannelTypeType)o.@type)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"access", @"", ((global::System.String)o.@access));
            if (o.@isolationSpecified) {
                WriteAttribute(@"isolation", @"", Write10_ChannelTypeIsolation(((global::ChannelTypeIsolation)o.@isolation)));
            }
            if (((global::System.Boolean)o.@enabled) != false) {
                WriteAttribute(@"enabled", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@enabled)));
            }
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            Write5_ChannelLoggingType(@"logging", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ChannelLoggingType)o.@logging), false, false);
            Write8_ChannelPublishingType(@"publishing", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ChannelPublishingType)o.@publishing), false, false);
            {
                global::System.Xml.XmlNode[] a = (global::System.Xml.XmlNode[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Xml.XmlNode ai = (global::System.Xml.XmlNode)a[ia];
                        if ((object)(ai) != null){
                            if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else if (ai is global::System.Xml.XmlNode) {
                                ((global::System.Xml.XmlNode)ai).WriteTo(Writer);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            if (o.@isolationSpecified) {
            }
            WriteEndElement(o);
        }

        void Write8_ChannelPublishingType(string n, string ns, global::ChannelPublishingType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ChannelPublishingType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChannelPublishingType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            if (((global::System.String)o.@level) != @"0") {
                WriteElementString(@"level", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@level));
            }
            if (((global::System.String)o.@keywords) != @"0") {
                WriteElementString(@"keywords", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@keywords));
            }
            WriteElementString(@"controlGuid", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@controlGuid));
            WriteElementString(@"bufferSize", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@bufferSize));
            WriteElementString(@"fileMax", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@fileMax));
            WriteElementString(@"minBuffers", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@minBuffers));
            WriteElementString(@"maxBuffers", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@maxBuffers));
            WriteElementString(@"latency", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@latency));
            if (((global::ChannelPublishingTypeClockType)o.@clockType) != global::ChannelPublishingTypeClockType.@SystemTime) {
                WriteElementString(@"clockType", @"http://schemas.microsoft.com/win/2004/08/events", Write6_ChannelPublishingTypeClockType(((global::ChannelPublishingTypeClockType)o.@clockType)));
            }
            if (o.@sidTypeSpecified) {
                WriteElementString(@"sidType", @"http://schemas.microsoft.com/win/2004/08/events", Write7_ChannelPublishingTypeSidType(((global::ChannelPublishingTypeSidType)o.@sidType)));
            }
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        string Write7_ChannelPublishingTypeSidType(global::ChannelPublishingTypeSidType v) {
            string s = null;
            switch (v) {
                case global::ChannelPublishingTypeSidType.@None: s = @"None"; break;
                case global::ChannelPublishingTypeSidType.@Publishing: s = @"Publishing"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelPublishingTypeSidType");
            }
            return s;
        }

        string Write6_ChannelPublishingTypeClockType(global::ChannelPublishingTypeClockType v) {
            string s = null;
            switch (v) {
                case global::ChannelPublishingTypeClockType.@SystemTime: s = @"SystemTime"; break;
                case global::ChannelPublishingTypeClockType.@QPC: s = @"QPC"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelPublishingTypeClockType");
            }
            return s;
        }

        void Write5_ChannelLoggingType(string n, string ns, global::ChannelLoggingType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ChannelLoggingType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ChannelLoggingType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            if (o.@autoBackupSpecified) {
                WriteElementStringRaw(@"autoBackup", @"http://schemas.microsoft.com/win/2004/08/events", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@autoBackup)));
            }
            if (((global::System.Boolean)o.@retention) != false) {
                WriteElementStringRaw(@"retention", @"http://schemas.microsoft.com/win/2004/08/events", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@retention)));
            }
            if (((global::System.String)o.@maxSize) != @"1048576") {
                WriteElementString(@"maxSize", @"http://schemas.microsoft.com/win/2004/08/events", ((global::System.String)o.@maxSize));
            }
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        string Write10_ChannelTypeIsolation(global::ChannelTypeIsolation v) {
            string s = null;
            switch (v) {
                case global::ChannelTypeIsolation.@Application: s = @"Application"; break;
                case global::ChannelTypeIsolation.@System: s = @"System"; break;
                case global::ChannelTypeIsolation.@Custom: s = @"Custom"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelTypeIsolation");
            }
            return s;
        }

        string Write9_ChannelTypeType(global::ChannelTypeType v) {
            string s = null;
            switch (v) {
                case global::ChannelTypeType.@Admin: s = @"Admin"; break;
                case global::ChannelTypeType.@Operational: s = @"Operational"; break;
                case global::ChannelTypeType.@Analytic: s = @"Analytic"; break;
                case global::ChannelTypeType.@Debug: s = @"Debug"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelTypeType");
            }
            return s;
        }

        void Write12_ImportChannelType(string n, string ns, global::ImportChannelType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ImportChannelType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ImportChannelType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"chid", @"", ((global::System.String)o.@chid));
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write66_XmlTypeListTypeXmlType(string n, string ns, global::XmlTypeListTypeXmlType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::XmlTypeListTypeXmlType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"XmlTypeListTypeXmlType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        string Write65_ProviderTypeSource(global::ProviderTypeSource v) {
            string s = null;
            switch (v) {
                case global::ProviderTypeSource.@Xml: s = @"Xml"; break;
                case global::ProviderTypeSource.@Wbem: s = @"Wbem"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ProviderTypeSource");
            }
            return s;
        }

        void Write33_TaskListType(string n, string ns, global::TaskListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TaskListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TaskListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::TaskType[] a = (global::TaskType[])o.@task;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write32_TaskType(@"task", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TaskType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write31_OpcodeListType(string n, string ns, global::OpcodeListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::OpcodeListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"OpcodeListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::OpcodeType[] a = (global::OpcodeType[])o.@opcode;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write30_OpcodeType(@"opcode", @"http://schemas.microsoft.com/win/2004/08/events", ((global::OpcodeType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write21_LevelListType(string n, string ns, global::LevelListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::LevelListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LevelListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::LevelType[] a = (global::LevelType[])o.@level;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write20_LevelType(@"level", @"http://schemas.microsoft.com/win/2004/08/events", ((global::LevelType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write19_KeywordListType(string n, string ns, global::KeywordListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::KeywordListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"KeywordListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::KeywordType[] a = (global::KeywordType[])o.@keyword;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write18_KeywordType(@"keyword", @"http://schemas.microsoft.com/win/2004/08/events", ((global::KeywordType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        string Write64_ChannelTypeIsolation(global::ChannelTypeIsolation v) {
            string s = null;
            switch (v) {
                case global::ChannelTypeIsolation.@Application: s = @"Application"; break;
                case global::ChannelTypeIsolation.@System: s = @"System"; break;
                case global::ChannelTypeIsolation.@Custom: s = @"Custom"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelTypeIsolation");
            }
            return s;
        }

        string Write63_ChannelTypeType(global::ChannelTypeType v) {
            string s = null;
            switch (v) {
                case global::ChannelTypeType.@Admin: s = @"Admin"; break;
                case global::ChannelTypeType.@Operational: s = @"Operational"; break;
                case global::ChannelTypeType.@Analytic: s = @"Analytic"; break;
                case global::ChannelTypeType.@Debug: s = @"Debug"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelTypeType");
            }
            return s;
        }

        string Write62_ChannelPublishingTypeSidType(global::ChannelPublishingTypeSidType v) {
            string s = null;
            switch (v) {
                case global::ChannelPublishingTypeSidType.@None: s = @"None"; break;
                case global::ChannelPublishingTypeSidType.@Publishing: s = @"Publishing"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelPublishingTypeSidType");
            }
            return s;
        }

        string Write61_ChannelPublishingTypeClockType(global::ChannelPublishingTypeClockType v) {
            string s = null;
            switch (v) {
                case global::ChannelPublishingTypeClockType.@SystemTime: s = @"SystemTime"; break;
                case global::ChannelPublishingTypeClockType.@QPC: s = @"QPC"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ChannelPublishingTypeClockType");
            }
            return s;
        }

        void Write41_ProviderType(string n, string ns, global::ProviderType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ProviderType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ProviderType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"namespace", @"", ((global::System.String)o.@namespace));
            WriteAttribute(@"guid", @"", ((global::System.String)o.@guid));
            WriteAttribute(@"resourceFileName", @"", ((global::System.String)o.@resourceFileName));
            WriteAttribute(@"messageFileName", @"", ((global::System.String)o.@messageFileName));
            WriteAttribute(@"parameterFileName", @"", ((global::System.String)o.@parameterFileName));
            WriteAttribute(@"helpLink", @"", ((global::System.String)o.@helpLink));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            if (((global::ProviderTypeSource)o.@source) != global::ProviderTypeSource.@Xml) {
                WriteAttribute(@"source", @"", Write40_ProviderTypeSource(((global::ProviderTypeSource)o.@source)));
            }
            if (((global::System.Boolean)o.@warnOnApplicationCompatibilityError) != false) {
                WriteAttribute(@"warnOnApplicationCompatibilityError", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@warnOnApplicationCompatibilityError)));
            }
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::ChannelListType) {
                                Write13_ChannelListType(@"channels", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ChannelListType)ai), false, false);
                            }
                            else if (ai is global::DefinitionType) {
                                Write15_DefinitionType(@"events", @"http://schemas.microsoft.com/win/2004/08/events", ((global::DefinitionType)ai), false, false);
                            }
                            else if (ai is global::FilterListType) {
                                Write17_FilterListType(@"filters", @"http://schemas.microsoft.com/win/2004/08/events", ((global::FilterListType)ai), false, false);
                            }
                            else if (ai is global::KeywordListType) {
                                Write19_KeywordListType(@"keywords", @"http://schemas.microsoft.com/win/2004/08/events", ((global::KeywordListType)ai), false, false);
                            }
                            else if (ai is global::LevelListType) {
                                Write21_LevelListType(@"levels", @"http://schemas.microsoft.com/win/2004/08/events", ((global::LevelListType)ai), false, false);
                            }
                            else if (ai is global::MapType) {
                                Write26_MapType(@"maps", @"http://schemas.microsoft.com/win/2004/08/events", ((global::MapType)ai), false, false);
                            }
                            else if (ai is global::NamedQueryType) {
                                Write29_NamedQueryType(@"namedQueries", @"http://schemas.microsoft.com/win/2004/08/events", ((global::NamedQueryType)ai), false, false);
                            }
                            else if (ai is global::OpcodeListType) {
                                Write31_OpcodeListType(@"opcodes", @"http://schemas.microsoft.com/win/2004/08/events", ((global::OpcodeListType)ai), false, false);
                            }
                            else if (ai is global::TaskListType) {
                                Write33_TaskListType(@"tasks", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TaskListType)ai), false, false);
                            }
                            else if (ai is global::TemplateListType) {
                                Write39_TemplateListType(@"templates", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TemplateListType)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write39_TemplateListType(string n, string ns, global::TemplateListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TemplateListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TemplateListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::TemplateItemType[] a = (global::TemplateItemType[])o.@template;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write38_TemplateItemType(@"template", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TemplateItemType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write38_TemplateItemType(string n, string ns, global::TemplateItemType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TemplateItemType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TemplateItemType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"tid", @"", ((global::System.String)o.@tid));
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::DataDefinitionType) {
                                Write34_DataDefinitionType(@"data", @"http://schemas.microsoft.com/win/2004/08/events", ((global::DataDefinitionType)ai), false, false);
                            }
                            else if (ai is global::StructDefinitionType) {
                                Write35_StructDefinitionType(@"struct", @"http://schemas.microsoft.com/win/2004/08/events", ((global::StructDefinitionType)ai), false, false);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            {
                global::TemplateItemTypeBinary[] a = (global::TemplateItemTypeBinary[])o.@binary;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write36_TemplateItemTypeBinary(@"binary", @"http://schemas.microsoft.com/win/2004/08/events", ((global::TemplateItemTypeBinary)a[ia]), false, false);
                    }
                }
            }
            {
                global::XmlType[] a = (global::XmlType[])o.@UserData;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write37_XmlType(@"UserData", @"http://schemas.microsoft.com/win/2004/08/events", ((global::XmlType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write37_XmlType(string n, string ns, global::XmlType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::XmlType)) {
                }
                else {
                    if (t == typeof(global::XmlTypeListTypeXmlType)) {
                        Write66_XmlTypeListTypeXmlType(n, ns,(global::XmlTypeListTypeXmlType)o, isNullable, true);
                        return;
                    }
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"XmlType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlElement[] a = (global::System.Xml.XmlElement[])o.@Any;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((a[ia]) is System.Xml.XmlNode || a[ia] == null) {
                            WriteElementLiteral((System.Xml.XmlNode)a[ia], @"", null, false, true);
                        }
                        else {
                            throw CreateInvalidAnyTypeException(a[ia]);
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write36_TemplateItemTypeBinary(string n, string ns, global::TemplateItemTypeBinary o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TemplateItemTypeBinary)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteEndElement(o);
        }

        void Write35_StructDefinitionType(string n, string ns, global::StructDefinitionType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StructDefinitionType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StructDefinitionType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"count", @"", ((global::System.String)o.@count));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::DataDefinitionType[] a = (global::DataDefinitionType[])o.@data;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write34_DataDefinitionType(@"data", @"http://schemas.microsoft.com/win/2004/08/events", ((global::DataDefinitionType)a[ia]), false, false);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write34_DataDefinitionType(string n, string ns, global::DataDefinitionType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DataDefinitionType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DataDefinitionType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"inType", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@inType)));
            WriteAttribute(@"outType", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@outType)));
            WriteAttribute(@"map", @"", ((global::System.String)o.@map));
            WriteAttribute(@"length", @"", ((global::System.String)o.@length));
            WriteAttribute(@"count", @"", ((global::System.String)o.@count));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write26_MapType(string n, string ns, global::MapType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::MapType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"MapType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::BitMapType) {
                                Write23_BitMapType(@"bitMap", @"http://schemas.microsoft.com/win/2004/08/events", ((global::BitMapType)ai), false, false);
                            }
                            else if (ai is global::ValueMapType) {
                                Write25_ValueMapType(@"valueMap", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ValueMapType)ai), false, false);
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write25_ValueMapType(string n, string ns, global::ValueMapType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ValueMapType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ValueMapType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::ValueMapValueType[] a = (global::ValueMapValueType[])o.@map;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write24_ValueMapValueType(@"map", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ValueMapValueType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write24_ValueMapValueType(string n, string ns, global::ValueMapValueType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::ValueMapValueType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"ValueMapValueType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write23_BitMapType(string n, string ns, global::BitMapType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::BitMapType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BitMapType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::BitMapValueType[] a = (global::BitMapValueType[])o.@map;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write22_BitMapValueType(@"map", @"http://schemas.microsoft.com/win/2004/08/events", ((global::BitMapValueType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write22_BitMapValueType(string n, string ns, global::BitMapValueType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::BitMapValueType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"BitMapValueType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write17_FilterListType(string n, string ns, global::FilterListType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::FilterListType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FilterListType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::FilterType[] a = (global::FilterType[])o.@filter;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write16_FilterType(@"filter", @"http://schemas.microsoft.com/win/2004/08/events", ((global::FilterType)a[ia]), false, false);
                    }
                }
            }
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write16_FilterType(string n, string ns, global::FilterType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::FilterType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"FilterType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"version", @"", ((global::System.String)o.@version));
            WriteAttribute(@"name", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@name)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"tid", @"", ((global::System.String)o.@tid));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write15_DefinitionType(string n, string ns, global::DefinitionType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::DefinitionType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"DefinitionType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::EventDefinitionType[] a = (global::EventDefinitionType[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write14_EventDefinitionType(@"event", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventDefinitionType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write14_EventDefinitionType(string n, string ns, global::EventDefinitionType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventDefinitionType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"EventDefinitionType", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"level", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@level)));
            WriteAttribute(@"template", @"", ((global::System.String)o.@template));
            WriteAttribute(@"channel", @"", ((global::System.String)o.@channel));
            {
                global::System.Xml.XmlQualifiedName[] a = (global::System.Xml.XmlQualifiedName[])o.@keywords;
                if (a != null) {
                    System.Text.StringBuilder sb = new System.Text.StringBuilder();
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlQualifiedName ai = (global::System.Xml.XmlQualifiedName)a[i];
                        if (i != 0) sb.Append(" ");
                        sb.Append(FromXmlQualifiedName(ai));
                    }
                    if (sb.Length != 0) {
                        WriteAttribute(@"keywords", @"", sb.ToString());
                    }
                }
            }
            WriteAttribute(@"task", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@task)));
            WriteAttribute(@"opcode", @"", FromXmlQualifiedName(((global::System.Xml.XmlQualifiedName)o.@opcode)));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteAttribute(@"version", @"", ((global::System.String)o.@version));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            if (((global::System.Boolean)o.@notLogged) != false) {
                WriteAttribute(@"notLogged", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@notLogged)));
            }
            if (((global::System.Boolean)o.@suppressProjection) != false) {
                WriteAttribute(@"suppressProjection", @"", System.Xml.XmlConvert.ToString((global::System.Boolean)((global::System.Boolean)o.@suppressProjection)));
            }
            if ((object)(o.@Value) != null){
                WriteValue(((global::System.String)o.@Value));
            }
            WriteEndElement(o);
        }

        string Write40_ProviderTypeSource(global::ProviderTypeSource v) {
            string s = null;
            switch (v) {
                case global::ProviderTypeSource.@Xml: s = @"Xml"; break;
                case global::ProviderTypeSource.@Wbem: s = @"Wbem"; break;
                default: throw CreateInvalidEnumValueException(((System.Int64)v).ToString(System.Globalization.CultureInfo.InvariantCulture), @"ProviderTypeSource");
            }
            return s;
        }

        void Write60_TemplateItemTypeBinary(string n, string ns, global::TemplateItemTypeBinary o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::TemplateItemTypeBinary)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"TemplateItemTypeBinary", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"name", @"", ((global::System.String)o.@name));
            WriteEndElement(o);
        }

        void Write59_LocalizationTypeResources(string n, string ns, global::LocalizationTypeResources o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::LocalizationTypeResources)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LocalizationTypeResources", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"culture", @"", ((global::System.String)o.@culture));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::StringTableType[] a = (global::StringTableType[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write45_StringTableType(@"stringTable", @"http://schemas.microsoft.com/win/2004/08/events", ((global::StringTableType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write45_StringTableType(string n, string ns, global::StringTableType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StringTableType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StringTableType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::StringTableTypeString[] a = (global::StringTableTypeString[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write44_StringTableTypeString(@"string", @"http://schemas.microsoft.com/win/2004/08/events", ((global::StringTableTypeString)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write44_StringTableTypeString(string n, string ns, global::StringTableTypeString o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StringTableTypeString)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"id", @"", ((global::System.String)o.@id));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"stringType", @"", ((global::System.String)o.@stringType));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write47_LocalizationType(string n, string ns, global::LocalizationType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::LocalizationType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"LocalizationType", @"http://schemas.microsoft.com/win/2004/08/events");
            if (((global::System.String)o.@fallbackCulture) != @"en-us") {
                WriteAttribute(@"fallbackCulture", @"", ((global::System.String)o.@fallbackCulture));
            }
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::LocalizationTypeResources) {
                                Write46_LocalizationTypeResources(@"resources", @"http://schemas.microsoft.com/win/2004/08/events", ((global::LocalizationTypeResources)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write46_LocalizationTypeResources(string n, string ns, global::LocalizationTypeResources o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::LocalizationTypeResources)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"culture", @"", ((global::System.String)o.@culture));
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::StringTableType[] a = (global::StringTableType[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write45_StringTableType(@"stringTable", @"http://schemas.microsoft.com/win/2004/08/events", ((global::StringTableType)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write58_StringTableTypeString(string n, string ns, global::StringTableTypeString o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::StringTableTypeString)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"StringTableTypeString", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"id", @"", ((global::System.String)o.@id));
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"stringType", @"", ((global::System.String)o.@stringType));
            {
                global::System.String[] a = (global::System.String[])o.@Text;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        if ((object)(a[ia]) != null){
                            WriteValue(((global::System.String)a[ia]));
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write57_EventsTypeMessageTableMessage(string n, string ns, global::EventsTypeMessageTableMessage o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventsTypeMessageTableMessage)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"EventsTypeMessageTableMessage", @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"mid", @"", ((global::System.String)o.@mid));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteEndElement(o);
        }

        void Write56_EventsTypeMessageTable(string n, string ns, global::EventsTypeMessageTable o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventsTypeMessageTable)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"EventsTypeMessageTable", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::EventsTypeMessageTableMessage[] a = (global::EventsTypeMessageTableMessage[])o.@message;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write3_EventsTypeMessageTableMessage(@"message", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventsTypeMessageTableMessage)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write3_EventsTypeMessageTableMessage(string n, string ns, global::EventsTypeMessageTableMessage o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventsTypeMessageTableMessage)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            WriteAttribute(@"value", @"", ((global::System.String)o.@value));
            WriteAttribute(@"mid", @"", ((global::System.String)o.@mid));
            WriteAttribute(@"message", @"", ((global::System.String)o.@message));
            WriteAttribute(@"symbol", @"", ((global::System.String)o.@symbol));
            WriteEndElement(o);
        }

        void Write42_EventsType(string n, string ns, global::EventsType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventsType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"EventsType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::ProviderType) {
                                Write41_ProviderType(@"provider", @"http://schemas.microsoft.com/win/2004/08/events", ((global::ProviderType)ai), false, false);
                            }
                            else if (ai is global::EventsTypeMessageTable) {
                                Write4_EventsTypeMessageTable(@"messageTable", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventsTypeMessageTable)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write4_EventsTypeMessageTable(string n, string ns, global::EventsTypeMessageTable o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::EventsTypeMessageTable)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::EventsTypeMessageTableMessage[] a = (global::EventsTypeMessageTableMessage[])o.@message;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        Write3_EventsTypeMessageTableMessage(@"message", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventsTypeMessageTableMessage)a[ia]), false, false);
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write43_InstrumentationType(string n, string ns, global::InstrumentationType o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::InstrumentationType)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(@"InstrumentationType", @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Xml.XmlAttribute[] a = (global::System.Xml.XmlAttribute[])o.@AnyAttr;
                if (a != null) {
                    for (int i = 0; i < a.Length; i++) {
                        global::System.Xml.XmlAttribute ai = (global::System.Xml.XmlAttribute)a[i];
                        WriteXmlAttribute(ai, o);
                    }
                }
            }
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::EventsType) {
                                Write42_EventsType(@"events", @"http://schemas.microsoft.com/win/2004/08/events", ((global::EventsType)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        void Write55_instrumentationManifest(string n, string ns, global::instrumentationManifest o, bool isNullable, bool needType) {
            if ((object)o == null) {
                if (isNullable) WriteNullTagLiteral(n, ns);
                return;
            }
            if (!needType) {
                System.Type t = o.GetType();
                if (t == typeof(global::instrumentationManifest)) {
                }
                else {
                    throw CreateUnknownTypeException(o);
                }
            }
            WriteStartElement(n, ns, o, false, null);
            if (needType) WriteXsiType(null, @"http://schemas.microsoft.com/win/2004/08/events");
            {
                global::System.Object[] a = (global::System.Object[])o.@Items;
                if (a != null) {
                    for (int ia = 0; ia < a.Length; ia++) {
                        global::System.Object ai = (global::System.Object)a[ia];
                        if ((object)(ai) != null){
                            if (ai is global::InstrumentationType) {
                                Write43_InstrumentationType(@"instrumentation", @"http://schemas.microsoft.com/win/2004/08/events", ((global::InstrumentationType)ai), false, false);
                            }
                            else if (ai is global::LocalizationType) {
                                Write47_LocalizationType(@"localization", @"http://schemas.microsoft.com/win/2004/08/events", ((global::LocalizationType)ai), false, false);
                            }
                            else if (ai is global::MetadataType) {
                                Write54_MetadataType(@"metadata", @"http://schemas.microsoft.com/win/2004/08/events", ((global::MetadataType)ai), false, false);
                            }
                            else if (ai is System.Xml.XmlElement) {
                                System.Xml.XmlElement elem = (System.Xml.XmlElement)ai;
                                if ((elem) is System.Xml.XmlNode || elem == null) {
                                    WriteElementLiteral((System.Xml.XmlNode)elem, @"", null, false, true);
                                }
                                else {
                                    throw CreateInvalidAnyTypeException(elem);
                                }
                            }
                            else  if ((object)(ai) != null){
                                throw CreateUnknownTypeException(ai);
                            }
                        }
                    }
                }
            }
            WriteEndElement(o);
        }

        protected override void InitCallbacks() {
        }
    }

    public class XmlSerializationReader1 : System.Xml.Serialization.XmlSerializationReader {

        public object Read68_instrumentationManifest() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id1_instrumentationManifest && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read55_instrumentationManifest(false, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:instrumentationManifest");
            }
            return (object)o;
        }

        public object Read69_InstrumentationType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id3_InstrumentationType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read43_InstrumentationType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":InstrumentationType");
            }
            return (object)o;
        }

        public object Read70_events() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id5_events && (object) Reader.NamespaceURI == (object)id2_Item)) {
                        o = Read42_EventsType(false, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:events");
            }
            return (object)o;
        }

        public object Read71_EventsTypeMessageTable() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id6_EventsTypeMessageTable && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read56_EventsTypeMessageTable(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":EventsTypeMessageTable");
            }
            return (object)o;
        }

        public object Read72_EventsTypeMessageTableMessage() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id7_EventsTypeMessageTableMessage && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read57_EventsTypeMessageTableMessage(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":EventsTypeMessageTableMessage");
            }
            return (object)o;
        }

        public object Read73_StringTableType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id8_StringTableType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read45_StringTableType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":StringTableType");
            }
            return (object)o;
        }

        public object Read74_StringTableTypeString() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id9_StringTableTypeString && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read58_StringTableTypeString(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":StringTableTypeString");
            }
            return (object)o;
        }

        public object Read75_LocalizationType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id10_LocalizationType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read47_LocalizationType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LocalizationType");
            }
            return (object)o;
        }

        public object Read76_LocalizationTypeResources() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id11_LocalizationTypeResources && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read59_LocalizationTypeResources(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LocalizationTypeResources");
            }
            return (object)o;
        }

        public object Read77_FilterType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id12_FilterType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read16_FilterType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":FilterType");
            }
            return (object)o;
        }

        public object Read78_FilterListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id13_FilterListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read17_FilterListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":FilterListType");
            }
            return (object)o;
        }

        public object Read79_DefinitionType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id14_DefinitionType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read15_DefinitionType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":DefinitionType");
            }
            return (object)o;
        }

        public object Read80_EventDefinitionType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id15_EventDefinitionType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read14_EventDefinitionType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":EventDefinitionType");
            }
            return (object)o;
        }

        public object Read81_TemplateListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id16_TemplateListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read39_TemplateListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TemplateListType");
            }
            return (object)o;
        }

        public object Read82_TemplateItemType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id17_TemplateItemType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read38_TemplateItemType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TemplateItemType");
            }
            return (object)o;
        }

        public object Read83_DataDefinitionType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id18_DataDefinitionType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read34_DataDefinitionType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":DataDefinitionType");
            }
            return (object)o;
        }

        public object Read84_StructDefinitionType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id19_StructDefinitionType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read35_StructDefinitionType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":StructDefinitionType");
            }
            return (object)o;
        }

        public object Read85_TemplateItemTypeBinary() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id20_TemplateItemTypeBinary && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read60_TemplateItemTypeBinary(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TemplateItemTypeBinary");
            }
            return (object)o;
        }

        public object Read86_XmlType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id21_XmlType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read37_XmlType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":XmlType");
            }
            return (object)o;
        }

        public object Read87_MapType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id22_MapType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read26_MapType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":MapType");
            }
            return (object)o;
        }

        public object Read88_BitMapType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id23_BitMapType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read23_BitMapType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":BitMapType");
            }
            return (object)o;
        }

        public object Read89_BitMapValueType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id24_BitMapValueType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read22_BitMapValueType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":BitMapValueType");
            }
            return (object)o;
        }

        public object Read90_ValueMapType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id25_ValueMapType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read25_ValueMapType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ValueMapType");
            }
            return (object)o;
        }

        public object Read91_ValueMapValueType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id26_ValueMapValueType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read24_ValueMapValueType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ValueMapValueType");
            }
            return (object)o;
        }

        public object Read92_ProviderType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id27_ProviderType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read41_ProviderType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ProviderType");
            }
            return (object)o;
        }

        public object Read93_ChannelListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id28_ChannelListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read13_ChannelListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelListType");
            }
            return (object)o;
        }

        public object Read94_ChannelType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id29_ChannelType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read11_ChannelType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelType");
            }
            return (object)o;
        }

        public object Read95_ChannelLoggingType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id30_ChannelLoggingType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read5_ChannelLoggingType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelLoggingType");
            }
            return (object)o;
        }

        public object Read96_ChannelPublishingType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id31_ChannelPublishingType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read8_ChannelPublishingType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelPublishingType");
            }
            return (object)o;
        }

        public object Read97_ChannelPublishingTypeClockType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id32_ChannelPublishingTypeClockType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        {
                            o = Read61_ChannelPublishingTypeClockType(Reader.ReadElementString());
                        }
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelPublishingTypeClockType");
            }
            return (object)o;
        }

        public object Read98_ChannelPublishingTypeSidType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id33_ChannelPublishingTypeSidType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        {
                            o = Read62_ChannelPublishingTypeSidType(Reader.ReadElementString());
                        }
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelPublishingTypeSidType");
            }
            return (object)o;
        }

        public object Read99_ChannelTypeType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id34_ChannelTypeType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        {
                            o = Read63_ChannelTypeType(Reader.ReadElementString());
                        }
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelTypeType");
            }
            return (object)o;
        }

        public object Read100_ChannelTypeIsolation() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id35_ChannelTypeIsolation && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        {
                            o = Read64_ChannelTypeIsolation(Reader.ReadElementString());
                        }
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ChannelTypeIsolation");
            }
            return (object)o;
        }

        public object Read101_ImportChannelType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id36_ImportChannelType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read12_ImportChannelType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ImportChannelType");
            }
            return (object)o;
        }

        public object Read102_KeywordListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id37_KeywordListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read19_KeywordListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":KeywordListType");
            }
            return (object)o;
        }

        public object Read103_KeywordType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id38_KeywordType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read18_KeywordType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":KeywordType");
            }
            return (object)o;
        }

        public object Read104_LevelListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id39_LevelListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read21_LevelListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LevelListType");
            }
            return (object)o;
        }

        public object Read105_LevelType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id40_LevelType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read20_LevelType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":LevelType");
            }
            return (object)o;
        }

        public object Read106_NamedQueryType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id41_NamedQueryType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read29_NamedQueryType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":NamedQueryType");
            }
            return (object)o;
        }

        public object Read107_PatternMapType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id42_PatternMapType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read28_PatternMapType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":PatternMapType");
            }
            return (object)o;
        }

        public object Read108_PatternMapValueType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id43_PatternMapValueType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read27_PatternMapValueType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":PatternMapValueType");
            }
            return (object)o;
        }

        public object Read109_OpcodeListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id44_OpcodeListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read31_OpcodeListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":OpcodeListType");
            }
            return (object)o;
        }

        public object Read110_OpcodeType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id45_OpcodeType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read30_OpcodeType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":OpcodeType");
            }
            return (object)o;
        }

        public object Read111_TaskListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id46_TaskListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read33_TaskListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TaskListType");
            }
            return (object)o;
        }

        public object Read112_TaskType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id47_TaskType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read32_TaskType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":TaskType");
            }
            return (object)o;
        }

        public object Read113_ProviderTypeSource() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id48_ProviderTypeSource && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        {
                            o = Read65_ProviderTypeSource(Reader.ReadElementString());
                        }
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":ProviderTypeSource");
            }
            return (object)o;
        }

        public object Read114_InputTypeListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id49_InputTypeListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read50_InputTypeListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":InputTypeListType");
            }
            return (object)o;
        }

        public object Read115_InputType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id50_InputType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read49_InputType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":InputType");
            }
            return (object)o;
        }

        public object Read116_OutputType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id51_OutputType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read48_OutputType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":OutputType");
            }
            return (object)o;
        }

        public object Read117_XmlTypeListType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id52_XmlTypeListType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read52_XmlTypeListType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":XmlTypeListType");
            }
            return (object)o;
        }

        public object Read118_XmlTypeListTypeXmlType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id53_XmlTypeListTypeXmlType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read66_XmlTypeListTypeXmlType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":XmlTypeListTypeXmlType");
            }
            return (object)o;
        }

        public object Read119_MetadataType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id54_MetadataType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read54_MetadataType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":MetadataType");
            }
            return (object)o;
        }

        public object Read120_MetadataTypeMessage() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id55_MetadataTypeMessage && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read67_MetadataTypeMessage(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":MetadataTypeMessage");
            }
            return (object)o;
        }

        public object Read121_InstrumentationManifestType() {
            object o = null;
            Reader.MoveToContent();
            if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                do {
                    if (((object) Reader.LocalName == (object)id56_InstrumentationManifestType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                        o = Read2_InstrumentationManifestType(true, true);
                        break;
                    }
                    throw CreateUnknownNodeException();
                } while (false);
            }
            else {
                UnknownNode(null, @":InstrumentationManifestType");
            }
            return (object)o;
        }

        global::InstrumentationManifestType Read2_InstrumentationManifestType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id56_InstrumentationManifestType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::InstrumentationManifestType o;
            o = new global::InstrumentationManifestType();
            bool[] paramsRead = new bool[0];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations0 = 0;
            int readerCount0 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations0, ref readerCount0);
            }
            ReadEndElement();
            return o;
        }

        global::MetadataTypeMessage Read67_MetadataTypeMessage(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id55_MetadataTypeMessage && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::MetadataTypeMessage o;
            o = new global::MetadataTypeMessage();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id58_mid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mid = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :mid, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations1 = 0;
            int readerCount1 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations1, ref readerCount1);
            }
            ReadEndElement();
            return o;
        }

        global::MetadataType Read54_MetadataType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id54_MetadataType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::MetadataType o;
            o = new global::MetadataType();
            global::LevelType[] a_1 = null;
            int ca_1 = 0;
            global::TaskType[] a_2 = null;
            int ca_2 = 0;
            global::OpcodeType[] a_3 = null;
            int ca_3 = 0;
            global::KeywordType[] a_4 = null;
            int ca_4 = 0;
            global::System.Object[] a_5 = null;
            int ca_5 = 0;
            global::MetadataTypeMessage[] a_7 = null;
            int ca_7 = 0;
            global::System.Xml.XmlElement[] a_8 = null;
            int ca_8 = 0;
            global::System.Xml.XmlAttribute[] a_10 = null;
            int ca_10 = 0;
            bool[] paramsRead = new bool[11];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[9] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = CollapseWhitespace(Reader.Value);
                    paramsRead[9] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_10 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_10, ca_10, typeof(global::System.Xml.XmlAttribute));a_10[ca_10++] = attr;
                }
            }
            o.@levels = (global::LevelType[])ShrinkArray(a_1, ca_1, typeof(global::LevelType), true);
            o.@tasks = (global::TaskType[])ShrinkArray(a_2, ca_2, typeof(global::TaskType), true);
            o.@opcodes = (global::OpcodeType[])ShrinkArray(a_3, ca_3, typeof(global::OpcodeType), true);
            o.@keywords = (global::KeywordType[])ShrinkArray(a_4, ca_4, typeof(global::KeywordType), true);
            o.@types = (global::System.Object[])ShrinkArray(a_5, ca_5, typeof(global::System.Object), true);
            o.@messageTable = (global::MetadataTypeMessage[])ShrinkArray(a_7, ca_7, typeof(global::MetadataTypeMessage), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_8, ca_8, typeof(global::System.Xml.XmlElement), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_8, ca_8, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations2 = 0;
            int readerCount2 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id62_channels && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@channels = Read13_ChannelListType(false, true);
                            paramsRead[0] = true;
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id63_levels && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::LevelType[] a_1_0 = null;
                                int ca_1_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations3 = 0;
                                    int readerCount3 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id64_level && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_1_0 = (global::LevelType[])EnsureArrayIndex(a_1_0, ca_1_0, typeof(global::LevelType));a_1_0[ca_1_0++] = Read20_LevelType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:level");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:level");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations3, ref readerCount3);
                                    }
                                ReadEndElement();
                                }
                                o.@levels = (global::LevelType[])ShrinkArray(a_1_0, ca_1_0, typeof(global::LevelType), false);
                            }
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id65_tasks && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::TaskType[] a_2_0 = null;
                                int ca_2_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations4 = 0;
                                    int readerCount4 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id66_task && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_2_0 = (global::TaskType[])EnsureArrayIndex(a_2_0, ca_2_0, typeof(global::TaskType));a_2_0[ca_2_0++] = Read32_TaskType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:task");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:task");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations4, ref readerCount4);
                                    }
                                ReadEndElement();
                                }
                                o.@tasks = (global::TaskType[])ShrinkArray(a_2_0, ca_2_0, typeof(global::TaskType), false);
                            }
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id67_opcodes && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::OpcodeType[] a_3_0 = null;
                                int ca_3_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations5 = 0;
                                    int readerCount5 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id68_opcode && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_3_0 = (global::OpcodeType[])EnsureArrayIndex(a_3_0, ca_3_0, typeof(global::OpcodeType));a_3_0[ca_3_0++] = Read30_OpcodeType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations5, ref readerCount5);
                                    }
                                ReadEndElement();
                                }
                                o.@opcodes = (global::OpcodeType[])ShrinkArray(a_3_0, ca_3_0, typeof(global::OpcodeType), false);
                            }
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id69_keywords && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::KeywordType[] a_4_0 = null;
                                int ca_4_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations6 = 0;
                                    int readerCount6 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id70_keyword && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_4_0 = (global::KeywordType[])EnsureArrayIndex(a_4_0, ca_4_0, typeof(global::KeywordType));a_4_0[ca_4_0++] = Read18_KeywordType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:keyword");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:keyword");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations6, ref readerCount6);
                                    }
                                ReadEndElement();
                                }
                                o.@keywords = (global::KeywordType[])ShrinkArray(a_4_0, ca_4_0, typeof(global::KeywordType), false);
                            }
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id71_types && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::System.Object[] a_5_0 = null;
                                int ca_5_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations7 = 0;
                                    int readerCount7 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id72_XmlElement && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_5_0 = (global::System.Object[])EnsureArrayIndex(a_5_0, ca_5_0, typeof(global::System.Object));a_5_0[ca_5_0++] = (global::System.Xml.XmlElement)ReadXmlNode(true);
                                                    break;
                                                }
                                                if (((object) Reader.LocalName == (object)id73_inTypes && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_5_0 = (global::System.Object[])EnsureArrayIndex(a_5_0, ca_5_0, typeof(global::System.Object));a_5_0[ca_5_0++] = Read50_InputTypeListType(false, true);
                                                    break;
                                                }
                                                if (((object) Reader.LocalName == (object)id74_xmlTypes && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_5_0 = (global::System.Object[])EnsureArrayIndex(a_5_0, ca_5_0, typeof(global::System.Object));a_5_0[ca_5_0++] = Read52_XmlTypeListType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:XmlElement, http://schemas.microsoft.com/win/2004/08/events:inTypes, http://schemas.microsoft.com/win/2004/08/events:xmlTypes");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:XmlElement, http://schemas.microsoft.com/win/2004/08/events:inTypes, http://schemas.microsoft.com/win/2004/08/events:xmlTypes");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations7, ref readerCount7);
                                    }
                                ReadEndElement();
                                }
                                o.@types = (global::System.Object[])ShrinkArray(a_5_0, ca_5_0, typeof(global::System.Object), false);
                            }
                            break;
                        }
                        if (!paramsRead[6] && ((object) Reader.LocalName == (object)id75_namedQueries && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@namedQueries = Read29_NamedQueryType(false, true);
                            paramsRead[6] = true;
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id76_messageTable && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::MetadataTypeMessage[] a_7_0 = null;
                                int ca_7_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations8 = 0;
                                    int readerCount8 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_7_0 = (global::MetadataTypeMessage[])EnsureArrayIndex(a_7_0, ca_7_0, typeof(global::MetadataTypeMessage));a_7_0[ca_7_0++] = Read53_MetadataTypeMessage(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:message");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:message");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations8, ref readerCount8);
                                    }
                                ReadEndElement();
                                }
                                o.@messageTable = (global::MetadataTypeMessage[])ShrinkArray(a_7_0, ca_7_0, typeof(global::MetadataTypeMessage), false);
                            }
                            break;
                        }
                        a_8 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_8, ca_8, typeof(global::System.Xml.XmlElement));a_8[ca_8++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:channels, http://schemas.microsoft.com/win/2004/08/events:levels, http://schemas.microsoft.com/win/2004/08/events:tasks, http://schemas.microsoft.com/win/2004/08/events:opcodes, http://schemas.microsoft.com/win/2004/08/events:keywords, http://schemas.microsoft.com/win/2004/08/events:types, http://schemas.microsoft.com/win/2004/08/events:namedQueries, http://schemas.microsoft.com/win/2004/08/events:messageTable");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations2, ref readerCount2);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlAttribute), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_8, ca_8, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::MetadataTypeMessage Read53_MetadataTypeMessage(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::MetadataTypeMessage o;
            o = new global::MetadataTypeMessage();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id58_mid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mid = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :mid, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations9 = 0;
            int readerCount9 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations9, ref readerCount9);
            }
            ReadEndElement();
            return o;
        }

        global::NamedQueryType Read29_NamedQueryType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id41_NamedQueryType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::NamedQueryType o;
            o = new global::NamedQueryType();
            global::PatternMapType[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlElement[] a_1 = null;
            int ca_1 = 0;
            global::System.Xml.XmlAttribute[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_2 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlAttribute));a_2[ca_2++] = attr;
                }
            }
            o.@patternMaps = (global::PatternMapType[])ShrinkArray(a_0, ca_0, typeof(global::PatternMapType), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlElement), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations10 = 0;
            int readerCount10 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id77_patternMaps && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::PatternMapType[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations11 = 0;
                                    int readerCount11 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id78_patternMap && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_0_0 = (global::PatternMapType[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::PatternMapType));a_0_0[ca_0_0++] = Read28_PatternMapType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:patternMap");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:patternMap");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations11, ref readerCount11);
                                    }
                                ReadEndElement();
                                }
                                o.@patternMaps = (global::PatternMapType[])ShrinkArray(a_0_0, ca_0_0, typeof(global::PatternMapType), false);
                            }
                            break;
                        }
                        a_1 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.Xml.XmlElement));a_1[ca_1++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:patternMaps");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations10, ref readerCount10);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::PatternMapType Read28_PatternMapType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id42_PatternMapType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::PatternMapType o;
            o = new global::PatternMapType();
            global::PatternMapValueType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id79_format && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@format = CollapseWhitespace(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :format, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@map = (global::PatternMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::PatternMapValueType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations12 = 0;
            int readerCount12 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id80_map && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::PatternMapValueType[])EnsureArrayIndex(a_0, ca_0, typeof(global::PatternMapValueType));a_0[ca_0++] = Read27_PatternMapValueType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations12, ref readerCount12);
            }
            o.@map = (global::PatternMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::PatternMapValueType), true);
            ReadEndElement();
            return o;
        }

        global::PatternMapValueType Read27_PatternMapValueType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id43_PatternMapValueType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::PatternMapValueType o;
            o = new global::PatternMapValueType();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :value");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations13 = 0;
            int readerCount13 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    tmp = ReadString(tmp, false);
                    o.@Value = tmp;
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations13, ref readerCount13);
            }
            ReadEndElement();
            return o;
        }

        global::XmlTypeListType Read52_XmlTypeListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id52_XmlTypeListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::XmlTypeListType o;
            o = new global::XmlTypeListType();
            global::XmlTypeListTypeXmlType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@xmlType = (global::XmlTypeListTypeXmlType[])ShrinkArray(a_0, ca_0, typeof(global::XmlTypeListTypeXmlType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations14 = 0;
            int readerCount14 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id81_xmlType && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::XmlTypeListTypeXmlType[])EnsureArrayIndex(a_0, ca_0, typeof(global::XmlTypeListTypeXmlType));a_0[ca_0++] = Read51_XmlTypeListTypeXmlType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:xmlType");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:xmlType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations14, ref readerCount14);
            }
            o.@xmlType = (global::XmlTypeListTypeXmlType[])ShrinkArray(a_0, ca_0, typeof(global::XmlTypeListTypeXmlType), true);
            ReadEndElement();
            return o;
        }

        global::XmlTypeListTypeXmlType Read51_XmlTypeListTypeXmlType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::XmlTypeListTypeXmlType o;
            o = new global::XmlTypeListTypeXmlType();
            global::System.Xml.XmlElement[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :value, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations15 = 0;
            int readerCount15 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    a_0 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Xml.XmlElement));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations15, ref readerCount15);
            }
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::InputTypeListType Read50_InputTypeListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id49_InputTypeListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::InputTypeListType o;
            o = new global::InputTypeListType();
            global::InputType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@inType = (global::InputType[])ShrinkArray(a_0, ca_0, typeof(global::InputType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations16 = 0;
            int readerCount16 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id82_inType && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::InputType[])EnsureArrayIndex(a_0, ca_0, typeof(global::InputType));a_0[ca_0++] = Read49_InputType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:inType");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:inType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations16, ref readerCount16);
            }
            o.@inType = (global::InputType[])ShrinkArray(a_0, ca_0, typeof(global::InputType), true);
            ReadEndElement();
            return o;
        }

        global::InputType Read49_InputType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id50_InputType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::InputType o;
            o = new global::InputType();
            global::OutputType[] a_1 = null;
            int ca_1 = 0;
            global::System.Xml.XmlElement[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[3] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :value, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@outType = (global::OutputType[])ShrinkArray(a_1, ca_1, typeof(global::OutputType), true);
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations17 = 0;
            int readerCount17 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id83_description && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@description = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id84_outType && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_1 = (global::OutputType[])EnsureArrayIndex(a_1, ca_1, typeof(global::OutputType));a_1[ca_1++] = Read48_OutputType(false, true);
                            break;
                        }
                        a_2 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlElement));a_2[ca_2++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:description, http://schemas.microsoft.com/win/2004/08/events:outType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations17, ref readerCount17);
            }
            o.@outType = (global::OutputType[])ShrinkArray(a_1, ca_1, typeof(global::OutputType), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::OutputType Read48_OutputType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id51_OutputType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::OutputType o;
            o = new global::OutputType();
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id85_default && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@default = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    o.@defaultSpecified = true;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id81_xmlType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@xmlType = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":default, :xmlType");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations18 = 0;
            int readerCount18 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    tmp = ReadString(tmp, false);
                    o.@Value = tmp;
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations18, ref readerCount18);
            }
            ReadEndElement();
            return o;
        }

        global::KeywordType Read18_KeywordType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id38_KeywordType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::KeywordType o;
            o = new global::KeywordType();
            global::System.Xml.XmlAttribute[] a_4 = null;
            int ca_4 = 0;
            global::System.String[] a_5 = null;
            int ca_5 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id86_mask && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mask = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_4 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_4, ca_4, typeof(global::System.Xml.XmlAttribute));a_4[ca_4++] = attr;
                }
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations19 = 0;
            int readerCount19 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_5 = (global::System.String[])EnsureArrayIndex(a_5, ca_5, typeof(global::System.String));a_5[ca_5++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations19, ref readerCount19);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::OpcodeType Read30_OpcodeType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id45_OpcodeType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::OpcodeType o;
            o = new global::OpcodeType();
            global::System.Xml.XmlAttribute[] a_5 = null;
            int ca_5 = 0;
            global::System.String[] a_6 = null;
            int ca_6 = 0;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id87_mofValue && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mofValue = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_5 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_5, ca_5, typeof(global::System.Xml.XmlAttribute));a_5[ca_5++] = attr;
                }
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_6, ca_6, typeof(global::System.String), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_6, ca_6, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations20 = 0;
            int readerCount20 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_6 = (global::System.String[])EnsureArrayIndex(a_6, ca_6, typeof(global::System.String));a_6[ca_6++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations20, ref readerCount20);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_6, ca_6, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::TaskType Read32_TaskType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id47_TaskType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TaskType o;
            o = new global::TaskType();
            global::OpcodeType[] a_0 = null;
            int ca_0 = 0;
            global::System.String[] a_1 = null;
            int ca_1 = 0;
            global::System.Xml.XmlAttribute[] a_7 = null;
            int ca_7 = 0;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[2] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id88_eventGUID && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@eventGUID = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_7 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_7, ca_7, typeof(global::System.Xml.XmlAttribute));a_7[ca_7++] = attr;
                }
            }
            o.@opcodes = (global::OpcodeType[])ShrinkArray(a_0, ca_0, typeof(global::OpcodeType), true);
            o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_7, ca_7, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_7, ca_7, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations21 = 0;
            int readerCount21 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id67_opcodes && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (!ReadNull()) {
                                global::OpcodeType[] a_0_0 = null;
                                int ca_0_0 = 0;
                                if ((Reader.IsEmptyElement)) {
                                    Reader.Skip();
                                }
                                else {
                                    Reader.ReadStartElement();
                                    Reader.MoveToContent();
                                    int whileIterations22 = 0;
                                    int readerCount22 = ReaderCount;
                                    while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                                        if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                                            do {
                                                if (((object) Reader.LocalName == (object)id68_opcode && (object) Reader.NamespaceURI == (object)id2_Item)) {
                                                    a_0_0 = (global::OpcodeType[])EnsureArrayIndex(a_0_0, ca_0_0, typeof(global::OpcodeType));a_0_0[ca_0_0++] = Read30_OpcodeType(false, true);
                                                    break;
                                                }
                                                UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                                            } while (false);
                                        }
                                        else {
                                            UnknownNode(null, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                                        }
                                        Reader.MoveToContent();
                                        CheckReaderCount(ref whileIterations22, ref readerCount22);
                                    }
                                ReadEndElement();
                                }
                                o.@opcodes = (global::OpcodeType[])ShrinkArray(a_0_0, ca_0_0, typeof(global::OpcodeType), false);
                            }
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:opcodes");
                    } while (false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_1 = (global::System.String[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.String));a_1[ca_1++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:opcodes");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations21, ref readerCount21);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_7, ca_7, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::LevelType Read20_LevelType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id40_LevelType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::LevelType o;
            o = new global::LevelType();
            global::System.Xml.XmlAttribute[] a_4 = null;
            int ca_4 = 0;
            global::System.String[] a_5 = null;
            int ca_5 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_4 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_4, ca_4, typeof(global::System.Xml.XmlAttribute));a_4[ca_4++] = attr;
                }
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations23 = 0;
            int readerCount23 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_5 = (global::System.String[])EnsureArrayIndex(a_5, ca_5, typeof(global::System.String));a_5[ca_5++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations23, ref readerCount23);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_5, ca_5, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::ChannelListType Read13_ChannelListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id28_ChannelListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ChannelListType o;
            o = new global::ChannelListType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_1 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.Xml.XmlAttribute));a_1[ca_1++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations24 = 0;
            int readerCount24 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id89_channel && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read11_ChannelType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id90_importChannel && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read12_ImportChannelType(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:channel, http://schemas.microsoft.com/win/2004/08/events:importChannel");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations24, ref readerCount24);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::ImportChannelType Read12_ImportChannelType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id36_ImportChannelType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ImportChannelType o;
            o = new global::ImportChannelType();
            global::System.String[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id91_chid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@chid = CollapseWhitespace(Reader.Value);
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":chid, :name, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations25 = 0;
            int readerCount25 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.String[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.String));a_3[ca_3++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations25, ref readerCount25);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::ChannelType Read11_ChannelType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id29_ChannelType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ChannelType o;
            o = new global::ChannelType();
            global::System.Xml.XmlNode[] a_2 = null;
            int ca_2 = 0;
            global::System.Xml.XmlAttribute[] a_12 = null;
            int ca_12 = 0;
            bool[] paramsRead = new bool[13];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[3] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = CollapseWhitespace(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id91_chid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@chid = CollapseWhitespace(Reader.Value);
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id92_type && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@type = Read9_ChannelTypeType(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id93_access && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@access = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id94_isolation && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@isolation = Read10_ChannelTypeIsolation(Reader.Value);
                    o.@isolationSpecified = true;
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id95_enabled && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@enabled = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[10] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[11] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_12 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_12, ca_12, typeof(global::System.Xml.XmlAttribute));a_12[ca_12++] = attr;
                }
            }
            o.@Any = (global::System.Xml.XmlNode[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlNode), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
                o.@Any = (global::System.Xml.XmlNode[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlNode), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations26 = 0;
            int readerCount26 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id96_logging && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@logging = Read5_ChannelLoggingType(false, true);
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id97_publishing && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@publishing = Read8_ChannelPublishingType(false, true);
                            paramsRead[1] = true;
                            break;
                        }
                        a_2 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlNode));a_2[ca_2++] = (global::System.Xml.XmlNode)ReadXmlNode(false);
                    } while (false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_2 = (global::System.Xml.XmlNode[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlNode));a_2[ca_2++] = (global::System.Xml.XmlNode)Document.CreateTextNode(Reader.ReadString());
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:logging, http://schemas.microsoft.com/win/2004/08/events:publishing");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations26, ref readerCount26);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
            o.@Any = (global::System.Xml.XmlNode[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlNode), true);
            ReadEndElement();
            return o;
        }

        global::ChannelPublishingType Read8_ChannelPublishingType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id31_ChannelPublishingType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ChannelPublishingType o;
            o = new global::ChannelPublishingType();
            global::System.Xml.XmlElement[] a_10 = null;
            int ca_10 = 0;
            global::System.Xml.XmlAttribute[] a_11 = null;
            int ca_11 = 0;
            bool[] paramsRead = new bool[12];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_11 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_11, ca_11, typeof(global::System.Xml.XmlAttribute));a_11[ca_11++] = attr;
                }
            }
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlElement), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_11, ca_11, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_11, ca_11, typeof(global::System.Xml.XmlAttribute), true);
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations27 = 0;
            int readerCount27 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id64_level && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@level = Reader.ReadElementString();
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id69_keywords && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@keywords = Reader.ReadElementString();
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id98_controlGuid && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@controlGuid = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        if (!paramsRead[3] && ((object) Reader.LocalName == (object)id99_bufferSize && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@bufferSize = Reader.ReadElementString();
                            }
                            paramsRead[3] = true;
                            break;
                        }
                        if (!paramsRead[4] && ((object) Reader.LocalName == (object)id100_fileMax && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@fileMax = Reader.ReadElementString();
                            }
                            paramsRead[4] = true;
                            break;
                        }
                        if (!paramsRead[5] && ((object) Reader.LocalName == (object)id101_minBuffers && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@minBuffers = Reader.ReadElementString();
                            }
                            paramsRead[5] = true;
                            break;
                        }
                        if (!paramsRead[6] && ((object) Reader.LocalName == (object)id102_maxBuffers && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@maxBuffers = Reader.ReadElementString();
                            }
                            paramsRead[6] = true;
                            break;
                        }
                        if (!paramsRead[7] && ((object) Reader.LocalName == (object)id103_latency && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@latency = Reader.ReadElementString();
                            }
                            paramsRead[7] = true;
                            break;
                        }
                        if (!paramsRead[8] && ((object) Reader.LocalName == (object)id104_clockType && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (Reader.IsEmptyElement) {
                                Reader.Skip();
                            }
                            else {
                                o.@clockType = Read6_ChannelPublishingTypeClockType(Reader.ReadElementString());
                            }
                            paramsRead[8] = true;
                            break;
                        }
                        if (!paramsRead[9] && ((object) Reader.LocalName == (object)id105_sidType && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@sidTypeSpecified = true;
                            {
                                o.@sidType = Read7_ChannelPublishingTypeSidType(Reader.ReadElementString());
                            }
                            paramsRead[9] = true;
                            break;
                        }
                        a_10 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_10, ca_10, typeof(global::System.Xml.XmlElement));a_10[ca_10++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:level, http://schemas.microsoft.com/win/2004/08/events:keywords, http://schemas.microsoft.com/win/2004/08/events:controlGuid, http://schemas.microsoft.com/win/2004/08/events:bufferSize, http://schemas.microsoft.com/win/2004/08/events:fileMax, http://schemas.microsoft.com/win/2004/08/events:minBuffers, http://schemas.microsoft.com/win/2004/08/events:maxBuffers, http://schemas.microsoft.com/win/2004/08/events:latency, http://schemas.microsoft.com/win/2004/08/events:clockType, http://schemas.microsoft.com/win/2004/08/events:sidType");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations27, ref readerCount27);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_11, ca_11, typeof(global::System.Xml.XmlAttribute), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_10, ca_10, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::ChannelPublishingTypeSidType Read7_ChannelPublishingTypeSidType(string s) {
            switch (s) {
                case @"None": return global::ChannelPublishingTypeSidType.@None;
                case @"Publishing": return global::ChannelPublishingTypeSidType.@Publishing;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelPublishingTypeSidType));
            }
        }

        global::ChannelPublishingTypeClockType Read6_ChannelPublishingTypeClockType(string s) {
            switch (s) {
                case @"SystemTime": return global::ChannelPublishingTypeClockType.@SystemTime;
                case @"QPC": return global::ChannelPublishingTypeClockType.@QPC;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelPublishingTypeClockType));
            }
        }

        global::ChannelLoggingType Read5_ChannelLoggingType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id30_ChannelLoggingType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ChannelLoggingType o;
            o = new global::ChannelLoggingType();
            global::System.Xml.XmlElement[] a_3 = null;
            int ca_3 = 0;
            global::System.Xml.XmlAttribute[] a_4 = null;
            int ca_4 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_4 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_4, ca_4, typeof(global::System.Xml.XmlAttribute));a_4[ca_4++] = attr;
                }
            }
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlElement), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations28 = 0;
            int readerCount28 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (!paramsRead[0] && ((object) Reader.LocalName == (object)id106_autoBackup && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            o.@autoBackupSpecified = true;
                            {
                                o.@autoBackup = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementString());
                            }
                            paramsRead[0] = true;
                            break;
                        }
                        if (!paramsRead[1] && ((object) Reader.LocalName == (object)id107_retention && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            if (Reader.IsEmptyElement) {
                                Reader.Skip();
                            }
                            else {
                                o.@retention = System.Xml.XmlConvert.ToBoolean(Reader.ReadElementString());
                            }
                            paramsRead[1] = true;
                            break;
                        }
                        if (!paramsRead[2] && ((object) Reader.LocalName == (object)id108_maxSize && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            {
                                o.@maxSize = Reader.ReadElementString();
                            }
                            paramsRead[2] = true;
                            break;
                        }
                        a_3 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.Xml.XmlElement));a_3[ca_3++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:autoBackup, http://schemas.microsoft.com/win/2004/08/events:retention, http://schemas.microsoft.com/win/2004/08/events:maxSize");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations28, ref readerCount28);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_3, ca_3, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::ChannelTypeIsolation Read10_ChannelTypeIsolation(string s) {
            switch (s) {
                case @"Application": return global::ChannelTypeIsolation.@Application;
                case @"System": return global::ChannelTypeIsolation.@System;
                case @"Custom": return global::ChannelTypeIsolation.@Custom;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelTypeIsolation));
            }
        }

        global::ChannelTypeType Read9_ChannelTypeType(string s) {
            switch (s) {
                case @"Admin": return global::ChannelTypeType.@Admin;
                case @"Operational": return global::ChannelTypeType.@Operational;
                case @"Analytic": return global::ChannelTypeType.@Analytic;
                case @"Debug": return global::ChannelTypeType.@Debug;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelTypeType));
            }
        }

        global::XmlTypeListTypeXmlType Read66_XmlTypeListTypeXmlType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlTypeListTypeXmlType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::XmlTypeListTypeXmlType o;
            o = new global::XmlTypeListTypeXmlType();
            global::System.Xml.XmlElement[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :value, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations29 = 0;
            int readerCount29 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    a_0 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Xml.XmlElement));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations29, ref readerCount29);
            }
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::ProviderTypeSource Read65_ProviderTypeSource(string s) {
            switch (s) {
                case @"Xml": return global::ProviderTypeSource.@Xml;
                case @"Wbem": return global::ProviderTypeSource.@Wbem;
                default: throw CreateUnknownConstantException(s, typeof(global::ProviderTypeSource));
            }
        }

        global::TaskListType Read33_TaskListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id46_TaskListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TaskListType o;
            o = new global::TaskListType();
            global::TaskType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@task = (global::TaskType[])ShrinkArray(a_0, ca_0, typeof(global::TaskType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations30 = 0;
            int readerCount30 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id66_task && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::TaskType[])EnsureArrayIndex(a_0, ca_0, typeof(global::TaskType));a_0[ca_0++] = Read32_TaskType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:task");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:task");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations30, ref readerCount30);
            }
            o.@task = (global::TaskType[])ShrinkArray(a_0, ca_0, typeof(global::TaskType), true);
            ReadEndElement();
            return o;
        }

        global::OpcodeListType Read31_OpcodeListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id44_OpcodeListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::OpcodeListType o;
            o = new global::OpcodeListType();
            global::OpcodeType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@opcode = (global::OpcodeType[])ShrinkArray(a_0, ca_0, typeof(global::OpcodeType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations31 = 0;
            int readerCount31 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id68_opcode && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::OpcodeType[])EnsureArrayIndex(a_0, ca_0, typeof(global::OpcodeType));a_0[ca_0++] = Read30_OpcodeType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:opcode");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations31, ref readerCount31);
            }
            o.@opcode = (global::OpcodeType[])ShrinkArray(a_0, ca_0, typeof(global::OpcodeType), true);
            ReadEndElement();
            return o;
        }

        global::LevelListType Read21_LevelListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id39_LevelListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::LevelListType o;
            o = new global::LevelListType();
            global::LevelType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@level = (global::LevelType[])ShrinkArray(a_0, ca_0, typeof(global::LevelType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations32 = 0;
            int readerCount32 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id64_level && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::LevelType[])EnsureArrayIndex(a_0, ca_0, typeof(global::LevelType));a_0[ca_0++] = Read20_LevelType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:level");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:level");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations32, ref readerCount32);
            }
            o.@level = (global::LevelType[])ShrinkArray(a_0, ca_0, typeof(global::LevelType), true);
            ReadEndElement();
            return o;
        }

        global::KeywordListType Read19_KeywordListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id37_KeywordListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::KeywordListType o;
            o = new global::KeywordListType();
            global::KeywordType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@keyword = (global::KeywordType[])ShrinkArray(a_0, ca_0, typeof(global::KeywordType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations33 = 0;
            int readerCount33 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id70_keyword && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::KeywordType[])EnsureArrayIndex(a_0, ca_0, typeof(global::KeywordType));a_0[ca_0++] = Read18_KeywordType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:keyword");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:keyword");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations33, ref readerCount33);
            }
            o.@keyword = (global::KeywordType[])ShrinkArray(a_0, ca_0, typeof(global::KeywordType), true);
            ReadEndElement();
            return o;
        }

        global::ChannelTypeIsolation Read64_ChannelTypeIsolation(string s) {
            switch (s) {
                case @"Application": return global::ChannelTypeIsolation.@Application;
                case @"System": return global::ChannelTypeIsolation.@System;
                case @"Custom": return global::ChannelTypeIsolation.@Custom;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelTypeIsolation));
            }
        }

        global::ChannelTypeType Read63_ChannelTypeType(string s) {
            switch (s) {
                case @"Admin": return global::ChannelTypeType.@Admin;
                case @"Operational": return global::ChannelTypeType.@Operational;
                case @"Analytic": return global::ChannelTypeType.@Analytic;
                case @"Debug": return global::ChannelTypeType.@Debug;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelTypeType));
            }
        }

        global::ChannelPublishingTypeSidType Read62_ChannelPublishingTypeSidType(string s) {
            switch (s) {
                case @"None": return global::ChannelPublishingTypeSidType.@None;
                case @"Publishing": return global::ChannelPublishingTypeSidType.@Publishing;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelPublishingTypeSidType));
            }
        }

        global::ChannelPublishingTypeClockType Read61_ChannelPublishingTypeClockType(string s) {
            switch (s) {
                case @"SystemTime": return global::ChannelPublishingTypeClockType.@SystemTime;
                case @"QPC": return global::ChannelPublishingTypeClockType.@QPC;
                default: throw CreateUnknownConstantException(s, typeof(global::ChannelPublishingTypeClockType));
            }
        }

        global::ProviderType Read41_ProviderType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id27_ProviderType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ProviderType o;
            o = new global::ProviderType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_12 = null;
            int ca_12 = 0;
            bool[] paramsRead = new bool[13];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = CollapseWhitespace(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id109_namespace && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@namespace = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id110_guid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@guid = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id111_resourceFileName && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@resourceFileName = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id112_messageFileName && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@messageFileName = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id113_parameterFileName && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@parameterFileName = Reader.Value;
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id114_helpLink && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@helpLink = CollapseWhitespace(Reader.Value);
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id115_source && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@source = Read40_ProviderTypeSource(Reader.Value);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id116_Item && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@warnOnApplicationCompatibilityError = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[11] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_12 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_12, ca_12, typeof(global::System.Xml.XmlAttribute));a_12[ca_12++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations34 = 0;
            int readerCount34 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id62_channels && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read13_ChannelListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id5_events && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read15_DefinitionType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id117_filters && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read17_FilterListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id69_keywords && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read19_KeywordListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id63_levels && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read21_LevelListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id118_maps && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read26_MapType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id75_namedQueries && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read29_NamedQueryType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id67_opcodes && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read31_OpcodeListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id65_tasks && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read33_TaskListType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id119_templates && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read39_TemplateListType(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:channels, http://schemas.microsoft.com/win/2004/08/events:events, http://schemas.microsoft.com/win/2004/08/events:filters, http://schemas.microsoft.com/win/2004/08/events:keywords, http://schemas.microsoft.com/win/2004/08/events:levels, http://schemas.microsoft.com/win/2004/08/events:maps, http://schemas.microsoft.com/win/2004/08/events:namedQueries, http://schemas.microsoft.com/win/2004/08/events:opcodes, http://schemas.microsoft.com/win/2004/08/events:tasks, http://schemas.microsoft.com/win/2004/08/events:templates");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations34, ref readerCount34);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_12, ca_12, typeof(global::System.Xml.XmlAttribute), true);
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::TemplateListType Read39_TemplateListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id16_TemplateListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TemplateListType o;
            o = new global::TemplateListType();
            global::TemplateItemType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@template = (global::TemplateItemType[])ShrinkArray(a_0, ca_0, typeof(global::TemplateItemType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations35 = 0;
            int readerCount35 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id120_template && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::TemplateItemType[])EnsureArrayIndex(a_0, ca_0, typeof(global::TemplateItemType));a_0[ca_0++] = Read38_TemplateItemType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:template");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:template");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations35, ref readerCount35);
            }
            o.@template = (global::TemplateItemType[])ShrinkArray(a_0, ca_0, typeof(global::TemplateItemType), true);
            ReadEndElement();
            return o;
        }

        global::TemplateItemType Read38_TemplateItemType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id17_TemplateItemType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TemplateItemType o;
            o = new global::TemplateItemType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::TemplateItemTypeBinary[] a_1 = null;
            int ca_1 = 0;
            global::XmlType[] a_2 = null;
            int ca_2 = 0;
            global::System.Xml.XmlAttribute[] a_5 = null;
            int ca_5 = 0;
            bool[] paramsRead = new bool[6];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[3] && ((object) Reader.LocalName == (object)id121_tid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@tid = CollapseWhitespace(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_5 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_5, ca_5, typeof(global::System.Xml.XmlAttribute));a_5[ca_5++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@binary = (global::TemplateItemTypeBinary[])ShrinkArray(a_1, ca_1, typeof(global::TemplateItemTypeBinary), true);
            o.@UserData = (global::XmlType[])ShrinkArray(a_2, ca_2, typeof(global::XmlType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                o.@binary = (global::TemplateItemTypeBinary[])ShrinkArray(a_1, ca_1, typeof(global::TemplateItemTypeBinary), true);
                o.@UserData = (global::XmlType[])ShrinkArray(a_2, ca_2, typeof(global::XmlType), true);
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations36 = 0;
            int readerCount36 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id122_data && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read34_DataDefinitionType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id123_struct && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read35_StructDefinitionType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id124_binary && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_1 = (global::TemplateItemTypeBinary[])EnsureArrayIndex(a_1, ca_1, typeof(global::TemplateItemTypeBinary));a_1[ca_1++] = Read36_TemplateItemTypeBinary(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id125_UserData && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_2 = (global::XmlType[])EnsureArrayIndex(a_2, ca_2, typeof(global::XmlType));a_2[ca_2++] = Read37_XmlType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:data, http://schemas.microsoft.com/win/2004/08/events:struct, http://schemas.microsoft.com/win/2004/08/events:binary, http://schemas.microsoft.com/win/2004/08/events:UserData");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:data, http://schemas.microsoft.com/win/2004/08/events:struct, http://schemas.microsoft.com/win/2004/08/events:binary, http://schemas.microsoft.com/win/2004/08/events:UserData");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations36, ref readerCount36);
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@binary = (global::TemplateItemTypeBinary[])ShrinkArray(a_1, ca_1, typeof(global::TemplateItemTypeBinary), true);
            o.@UserData = (global::XmlType[])ShrinkArray(a_2, ca_2, typeof(global::XmlType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_5, ca_5, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::XmlType Read37_XmlType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id21_XmlType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                if (((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id53_XmlTypeListTypeXmlType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item))
                    return Read66_XmlTypeListTypeXmlType(isNullable, false);
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::XmlType o;
            o = new global::XmlType();
            global::System.Xml.XmlElement[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations37 = 0;
            int readerCount37 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    a_0 = (global::System.Xml.XmlElement[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Xml.XmlElement));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations37, ref readerCount37);
            }
            o.@Any = (global::System.Xml.XmlElement[])ShrinkArray(a_0, ca_0, typeof(global::System.Xml.XmlElement), true);
            ReadEndElement();
            return o;
        }

        global::TemplateItemTypeBinary Read36_TemplateItemTypeBinary(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TemplateItemTypeBinary o;
            o = new global::TemplateItemTypeBinary();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations38 = 0;
            int readerCount38 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations38, ref readerCount38);
            }
            ReadEndElement();
            return o;
        }

        global::StructDefinitionType Read35_StructDefinitionType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id19_StructDefinitionType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::StructDefinitionType o;
            o = new global::StructDefinitionType();
            global::DataDefinitionType[] a_0 = null;
            int ca_0 = 0;
            global::System.String[] a_1 = null;
            int ca_1 = 0;
            global::System.Xml.XmlAttribute[] a_4 = null;
            int ca_4 = 0;
            bool[] paramsRead = new bool[5];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[2] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id126_count && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@count = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_4 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_4, ca_4, typeof(global::System.Xml.XmlAttribute));a_4[ca_4++] = attr;
                }
            }
            o.@data = (global::DataDefinitionType[])ShrinkArray(a_0, ca_0, typeof(global::DataDefinitionType), true);
            o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@data = (global::DataDefinitionType[])ShrinkArray(a_0, ca_0, typeof(global::DataDefinitionType), true);
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations39 = 0;
            int readerCount39 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id122_data && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::DataDefinitionType[])EnsureArrayIndex(a_0, ca_0, typeof(global::DataDefinitionType));a_0[ca_0++] = Read34_DataDefinitionType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:data");
                    } while (false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_1 = (global::System.String[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.String));a_1[ca_1++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:data");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations39, ref readerCount39);
            }
            o.@data = (global::DataDefinitionType[])ShrinkArray(a_0, ca_0, typeof(global::DataDefinitionType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::DataDefinitionType Read34_DataDefinitionType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id18_DataDefinitionType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::DataDefinitionType o;
            o = new global::DataDefinitionType();
            global::System.Xml.XmlAttribute[] a_6 = null;
            int ca_6 = 0;
            global::System.String[] a_7 = null;
            int ca_7 = 0;
            bool[] paramsRead = new bool[8];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id82_inType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@inType = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id84_outType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@outType = ToXmlQualifiedName(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id80_map && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@map = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id127_length && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@length = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id126_count && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@count = Reader.Value;
                    paramsRead[5] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_6 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_6, ca_6, typeof(global::System.Xml.XmlAttribute));a_6[ca_6++] = attr;
                }
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_6, ca_6, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_7, ca_7, typeof(global::System.String), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_6, ca_6, typeof(global::System.Xml.XmlAttribute), true);
                o.@Text = (global::System.String[])ShrinkArray(a_7, ca_7, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations40 = 0;
            int readerCount40 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_7 = (global::System.String[])EnsureArrayIndex(a_7, ca_7, typeof(global::System.String));a_7[ca_7++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations40, ref readerCount40);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_6, ca_6, typeof(global::System.Xml.XmlAttribute), true);
            o.@Text = (global::System.String[])ShrinkArray(a_7, ca_7, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::MapType Read26_MapType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id22_MapType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::MapType o;
            o = new global::MapType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations41 = 0;
            int readerCount41 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id128_bitMap && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read23_BitMapType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id129_valueMap && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read25_ValueMapType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:bitMap, http://schemas.microsoft.com/win/2004/08/events:valueMap");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:bitMap, http://schemas.microsoft.com/win/2004/08/events:valueMap");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations41, ref readerCount41);
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::ValueMapType Read25_ValueMapType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id25_ValueMapType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ValueMapType o;
            o = new global::ValueMapType();
            global::ValueMapValueType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@map = (global::ValueMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::ValueMapValueType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations42 = 0;
            int readerCount42 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id80_map && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::ValueMapValueType[])EnsureArrayIndex(a_0, ca_0, typeof(global::ValueMapValueType));a_0[ca_0++] = Read24_ValueMapValueType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations42, ref readerCount42);
            }
            o.@map = (global::ValueMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::ValueMapValueType), true);
            ReadEndElement();
            return o;
        }

        global::ValueMapValueType Read24_ValueMapValueType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id26_ValueMapValueType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::ValueMapValueType o;
            o = new global::ValueMapValueType();
            global::System.String[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations43 = 0;
            int readerCount43 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.String[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.String));a_3[ca_3++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations43, ref readerCount43);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::BitMapType Read23_BitMapType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id23_BitMapType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::BitMapType o;
            o = new global::BitMapType();
            global::BitMapValueType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@map = (global::BitMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::BitMapValueType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations44 = 0;
            int readerCount44 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id80_map && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::BitMapValueType[])EnsureArrayIndex(a_0, ca_0, typeof(global::BitMapValueType));a_0[ca_0++] = Read22_BitMapValueType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:map");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations44, ref readerCount44);
            }
            o.@map = (global::BitMapValueType[])ShrinkArray(a_0, ca_0, typeof(global::BitMapValueType), true);
            ReadEndElement();
            return o;
        }

        global::BitMapValueType Read22_BitMapValueType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id24_BitMapValueType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::BitMapValueType o;
            o = new global::BitMapValueType();
            global::System.String[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations45 = 0;
            int readerCount45 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.String[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.String));a_3[ca_3++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations45, ref readerCount45);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::FilterListType Read17_FilterListType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id13_FilterListType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::FilterListType o;
            o = new global::FilterListType();
            global::FilterType[] a_0 = null;
            int ca_0 = 0;
            global::System.String[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@filter = (global::FilterType[])ShrinkArray(a_0, ca_0, typeof(global::FilterType), true);
                o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations46 = 0;
            int readerCount46 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id130_filter && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::FilterType[])EnsureArrayIndex(a_0, ca_0, typeof(global::FilterType));a_0[ca_0++] = Read16_FilterType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:filter");
                    } while (false);
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_1 = (global::System.String[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.String));a_1[ca_1++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:filter");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations46, ref readerCount46);
            }
            o.@filter = (global::FilterType[])ShrinkArray(a_0, ca_0, typeof(global::FilterType), true);
            o.@Text = (global::System.String[])ShrinkArray(a_1, ca_1, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::FilterType Read16_FilterType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id12_FilterType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::FilterType o;
            o = new global::FilterType();
            global::System.String[] a_6 = null;
            int ca_6 = 0;
            bool[] paramsRead = new bool[7];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id131_version && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@version = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = ToXmlQualifiedName(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!paramsRead[4] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[4] = true;
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id121_tid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@tid = CollapseWhitespace(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :version, :name, :symbol, :message, :tid");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_6, ca_6, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations47 = 0;
            int readerCount47 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_6 = (global::System.String[])EnsureArrayIndex(a_6, ca_6, typeof(global::System.String));a_6[ca_6++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations47, ref readerCount47);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_6, ca_6, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::DefinitionType Read15_DefinitionType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id14_DefinitionType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::DefinitionType o;
            o = new global::DefinitionType();
            global::EventDefinitionType[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::EventDefinitionType[])ShrinkArray(a_0, ca_0, typeof(global::EventDefinitionType), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations48 = 0;
            int readerCount48 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id132_event && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::EventDefinitionType[])EnsureArrayIndex(a_0, ca_0, typeof(global::EventDefinitionType));a_0[ca_0++] = Read14_EventDefinitionType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:event");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:event");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations48, ref readerCount48);
            }
            o.@Items = (global::EventDefinitionType[])ShrinkArray(a_0, ca_0, typeof(global::EventDefinitionType), true);
            ReadEndElement();
            return o;
        }

        global::EventDefinitionType Read14_EventDefinitionType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id15_EventDefinitionType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventDefinitionType o;
            o = new global::EventDefinitionType();
            global::System.Xml.XmlQualifiedName[] a_4 = null;
            int ca_4 = 0;
            bool[] paramsRead = new bool[13];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id64_level && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@level = ToXmlQualifiedName(Reader.Value);
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id120_template && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@template = CollapseWhitespace(Reader.Value);
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id89_channel && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@channel = CollapseWhitespace(Reader.Value);
                    paramsRead[3] = true;
                }
                else if (((object) Reader.LocalName == (object)id69_keywords && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    string listValues = Reader.Value;
                    string[] vals = listValues.Split(null);
                    for (int i = 0; i < vals.Length; i++) {
                        a_4 = (global::System.Xml.XmlQualifiedName[])EnsureArrayIndex(a_4, ca_4, typeof(global::System.Xml.XmlQualifiedName));a_4[ca_4++] = ToXmlQualifiedName(vals[i]);
                    }
                }
                else if (!paramsRead[5] && ((object) Reader.LocalName == (object)id66_task && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@task = ToXmlQualifiedName(Reader.Value);
                    paramsRead[5] = true;
                }
                else if (!paramsRead[6] && ((object) Reader.LocalName == (object)id68_opcode && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@opcode = ToXmlQualifiedName(Reader.Value);
                    paramsRead[6] = true;
                }
                else if (!paramsRead[7] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[7] = true;
                }
                else if (!paramsRead[8] && ((object) Reader.LocalName == (object)id131_version && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@version = Reader.Value;
                    paramsRead[8] = true;
                }
                else if (!paramsRead[9] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[9] = true;
                }
                else if (!paramsRead[10] && ((object) Reader.LocalName == (object)id133_notLogged && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@notLogged = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[10] = true;
                }
                else if (!paramsRead[11] && ((object) Reader.LocalName == (object)id134_suppressProjection && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@suppressProjection = System.Xml.XmlConvert.ToBoolean(Reader.Value);
                    paramsRead[11] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :level, :template, :channel, :keywords, :task, :opcode, :symbol, :version, :message, :notLogged, :suppressProjection");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@keywords = (global::System.Xml.XmlQualifiedName[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlQualifiedName), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations49 = 0;
            int readerCount49 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    tmp = ReadString(tmp, false);
                    o.@Value = tmp;
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations49, ref readerCount49);
            }
            o.@keywords = (global::System.Xml.XmlQualifiedName[])ShrinkArray(a_4, ca_4, typeof(global::System.Xml.XmlQualifiedName), true);
            ReadEndElement();
            return o;
        }

        global::ProviderTypeSource Read40_ProviderTypeSource(string s) {
            switch (s) {
                case @"Xml": return global::ProviderTypeSource.@Xml;
                case @"Wbem": return global::ProviderTypeSource.@Wbem;
                default: throw CreateUnknownConstantException(s, typeof(global::ProviderTypeSource));
            }
        }

        global::TemplateItemTypeBinary Read60_TemplateItemTypeBinary(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id20_TemplateItemTypeBinary && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::TemplateItemTypeBinary o;
            o = new global::TemplateItemTypeBinary();
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id61_name && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@name = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":name");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations50 = 0;
            int readerCount50 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations50, ref readerCount50);
            }
            ReadEndElement();
            return o;
        }

        global::LocalizationTypeResources Read59_LocalizationTypeResources(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id11_LocalizationTypeResources && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::LocalizationTypeResources o;
            o = new global::LocalizationTypeResources();
            global::StringTableType[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id135_culture && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@culture = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_2 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlAttribute));a_2[ca_2++] = attr;
                }
            }
            o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations51 = 0;
            int readerCount51 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id136_stringTable && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::StringTableType[])EnsureArrayIndex(a_0, ca_0, typeof(global::StringTableType));a_0[ca_0++] = Read45_StringTableType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:stringTable");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:stringTable");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations51, ref readerCount51);
            }
            o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::StringTableType Read45_StringTableType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id8_StringTableType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::StringTableType o;
            o = new global::StringTableType();
            global::StringTableTypeString[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_1 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.Xml.XmlAttribute));a_1[ca_1++] = attr;
                }
            }
            o.@Items = (global::StringTableTypeString[])ShrinkArray(a_0, ca_0, typeof(global::StringTableTypeString), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::StringTableTypeString[])ShrinkArray(a_0, ca_0, typeof(global::StringTableTypeString), true);
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations52 = 0;
            int readerCount52 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id137_string && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::StringTableTypeString[])EnsureArrayIndex(a_0, ca_0, typeof(global::StringTableTypeString));a_0[ca_0++] = Read44_StringTableTypeString(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:string");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:string");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations52, ref readerCount52);
            }
            o.@Items = (global::StringTableTypeString[])ShrinkArray(a_0, ca_0, typeof(global::StringTableTypeString), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::StringTableTypeString Read44_StringTableTypeString(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::StringTableTypeString o;
            o = new global::StringTableTypeString();
            global::System.String[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id138_id && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id139_stringType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@stringType = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":id, :value, :stringType");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations53 = 0;
            int readerCount53 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.String[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.String));a_3[ca_3++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations53, ref readerCount53);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::LocalizationType Read47_LocalizationType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id10_LocalizationType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::LocalizationType o;
            o = new global::LocalizationType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id140_fallbackCulture && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@fallbackCulture = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_2 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlAttribute));a_2[ca_2++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations54 = 0;
            int readerCount54 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id141_resources && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read46_LocalizationTypeResources(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:resources");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations54, ref readerCount54);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::LocalizationTypeResources Read46_LocalizationTypeResources(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::LocalizationTypeResources o;
            o = new global::LocalizationTypeResources();
            global::StringTableType[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_2 = null;
            int ca_2 = 0;
            bool[] paramsRead = new bool[3];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[1] && ((object) Reader.LocalName == (object)id135_culture && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@culture = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_2 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_2, ca_2, typeof(global::System.Xml.XmlAttribute));a_2[ca_2++] = attr;
                }
            }
            o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations55 = 0;
            int readerCount55 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id136_stringTable && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::StringTableType[])EnsureArrayIndex(a_0, ca_0, typeof(global::StringTableType));a_0[ca_0++] = Read45_StringTableType(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:stringTable");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:stringTable");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations55, ref readerCount55);
            }
            o.@Items = (global::StringTableType[])ShrinkArray(a_0, ca_0, typeof(global::StringTableType), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_2, ca_2, typeof(global::System.Xml.XmlAttribute), true);
            ReadEndElement();
            return o;
        }

        global::StringTableTypeString Read58_StringTableTypeString(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id9_StringTableTypeString && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::StringTableTypeString o;
            o = new global::StringTableTypeString();
            global::System.String[] a_3 = null;
            int ca_3 = 0;
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id138_id && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@id = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id139_stringType && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@stringType = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":id, :value, :stringType");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations56 = 0;
            int readerCount56 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                string tmp = null;
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else if (Reader.NodeType == System.Xml.XmlNodeType.Text || 
                Reader.NodeType == System.Xml.XmlNodeType.CDATA || 
                Reader.NodeType == System.Xml.XmlNodeType.Whitespace || 
                Reader.NodeType == System.Xml.XmlNodeType.SignificantWhitespace) {
                    a_3 = (global::System.String[])EnsureArrayIndex(a_3, ca_3, typeof(global::System.String));a_3[ca_3++] = Reader.ReadString();
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations56, ref readerCount56);
            }
            o.@Text = (global::System.String[])ShrinkArray(a_3, ca_3, typeof(global::System.String), true);
            ReadEndElement();
            return o;
        }

        global::EventsTypeMessageTableMessage Read57_EventsTypeMessageTableMessage(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id7_EventsTypeMessageTableMessage && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventsTypeMessageTableMessage o;
            o = new global::EventsTypeMessageTableMessage();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id58_mid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mid = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :mid, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations57 = 0;
            int readerCount57 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations57, ref readerCount57);
            }
            ReadEndElement();
            return o;
        }

        global::EventsTypeMessageTable Read56_EventsTypeMessageTable(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id6_EventsTypeMessageTable && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventsTypeMessageTable o;
            o = new global::EventsTypeMessageTable();
            global::EventsTypeMessageTableMessage[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@message = (global::EventsTypeMessageTableMessage[])ShrinkArray(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations58 = 0;
            int readerCount58 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::EventsTypeMessageTableMessage[])EnsureArrayIndex(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage));a_0[ca_0++] = Read3_EventsTypeMessageTableMessage(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:message");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:message");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations58, ref readerCount58);
            }
            o.@message = (global::EventsTypeMessageTableMessage[])ShrinkArray(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage), true);
            ReadEndElement();
            return o;
        }

        global::EventsTypeMessageTableMessage Read3_EventsTypeMessageTableMessage(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventsTypeMessageTableMessage o;
            o = new global::EventsTypeMessageTableMessage();
            bool[] paramsRead = new bool[4];
            while (Reader.MoveToNextAttribute()) {
                if (!paramsRead[0] && ((object) Reader.LocalName == (object)id57_value && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@value = Reader.Value;
                    paramsRead[0] = true;
                }
                else if (!paramsRead[1] && ((object) Reader.LocalName == (object)id58_mid && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@mid = Reader.Value;
                    paramsRead[1] = true;
                }
                else if (!paramsRead[2] && ((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@message = Reader.Value;
                    paramsRead[2] = true;
                }
                else if (!paramsRead[3] && ((object) Reader.LocalName == (object)id60_symbol && (object) Reader.NamespaceURI == (object)id4_Item)) {
                    o.@symbol = Reader.Value;
                    paramsRead[3] = true;
                }
                else if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o, @":value, :mid, :message, :symbol");
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations59 = 0;
            int readerCount59 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    UnknownNode((object)o, @"");
                }
                else {
                    UnknownNode((object)o, @"");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations59, ref readerCount59);
            }
            ReadEndElement();
            return o;
        }

        global::EventsType Read42_EventsType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id142_EventsType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventsType o;
            o = new global::EventsType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_1 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.Xml.XmlAttribute));a_1[ca_1++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations60 = 0;
            int readerCount60 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id76_messageTable && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read4_EventsTypeMessageTable(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id143_provider && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read41_ProviderType(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:messageTable, http://schemas.microsoft.com/win/2004/08/events:provider");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations60, ref readerCount60);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::EventsTypeMessageTable Read4_EventsTypeMessageTable(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::EventsTypeMessageTable o;
            o = new global::EventsTypeMessageTable();
            global::EventsTypeMessageTableMessage[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@message = (global::EventsTypeMessageTableMessage[])ShrinkArray(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations61 = 0;
            int readerCount61 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id59_message && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::EventsTypeMessageTableMessage[])EnsureArrayIndex(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage));a_0[ca_0++] = Read3_EventsTypeMessageTableMessage(false, true);
                            break;
                        }
                        UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:message");
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:message");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations61, ref readerCount61);
            }
            o.@message = (global::EventsTypeMessageTableMessage[])ShrinkArray(a_0, ca_0, typeof(global::EventsTypeMessageTableMessage), true);
            ReadEndElement();
            return o;
        }

        global::InstrumentationType Read43_InstrumentationType(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id3_InstrumentationType && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::InstrumentationType o;
            o = new global::InstrumentationType();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            global::System.Xml.XmlAttribute[] a_1 = null;
            int ca_1 = 0;
            bool[] paramsRead = new bool[2];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    System.Xml.XmlAttribute attr = (System.Xml.XmlAttribute) Document.ReadNode(Reader);
                    ParseWsdlArrayType(attr);
                    a_1 = (global::System.Xml.XmlAttribute[])EnsureArrayIndex(a_1, ca_1, typeof(global::System.Xml.XmlAttribute));a_1[ca_1++] = attr;
                }
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations62 = 0;
            int readerCount62 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id5_events && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read42_EventsType(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:events");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations62, ref readerCount62);
            }
            o.@AnyAttr = (global::System.Xml.XmlAttribute[])ShrinkArray(a_1, ca_1, typeof(global::System.Xml.XmlAttribute), true);
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        global::instrumentationManifest Read55_instrumentationManifest(bool isNullable, bool checkType) {
            System.Xml.XmlQualifiedName xsiType = checkType ? GetXsiType() : null;
            bool isNull = false;
            if (isNullable) isNull = ReadNull();
            if (checkType) {
            if (xsiType == null || ((object) ((System.Xml.XmlQualifiedName)xsiType).Name == (object)id4_Item && (object) ((System.Xml.XmlQualifiedName)xsiType).Namespace == (object)id2_Item)) {
            }
            else {
                throw CreateUnknownTypeException((System.Xml.XmlQualifiedName)xsiType);
            }
            }
            if (isNull) return null;
            global::instrumentationManifest o;
            o = new global::instrumentationManifest();
            global::System.Object[] a_0 = null;
            int ca_0 = 0;
            bool[] paramsRead = new bool[1];
            while (Reader.MoveToNextAttribute()) {
                if (!IsXmlnsAttribute(Reader.Name)) {
                    UnknownNode((object)o);
                }
            }
            Reader.MoveToElement();
            if (Reader.IsEmptyElement) {
                Reader.Skip();
                o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
                return o;
            }
            Reader.ReadStartElement();
            Reader.MoveToContent();
            int whileIterations63 = 0;
            int readerCount63 = ReaderCount;
            while (Reader.NodeType != System.Xml.XmlNodeType.EndElement && Reader.NodeType != System.Xml.XmlNodeType.None) {
                if (Reader.NodeType == System.Xml.XmlNodeType.Element) {
                    do {
                        if (((object) Reader.LocalName == (object)id144_instrumentation && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read43_InstrumentationType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id145_localization && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read47_LocalizationType(false, true);
                            break;
                        }
                        if (((object) Reader.LocalName == (object)id146_metadata && (object) Reader.NamespaceURI == (object)id2_Item)) {
                            a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = Read54_MetadataType(false, true);
                            break;
                        }
                        a_0 = (global::System.Object[])EnsureArrayIndex(a_0, ca_0, typeof(global::System.Object));a_0[ca_0++] = (global::System.Xml.XmlElement)ReadXmlNode(false);
                    } while (false);
                }
                else {
                    UnknownNode((object)o, @"http://schemas.microsoft.com/win/2004/08/events:instrumentation, http://schemas.microsoft.com/win/2004/08/events:localization, http://schemas.microsoft.com/win/2004/08/events:metadata");
                }
                Reader.MoveToContent();
                CheckReaderCount(ref whileIterations63, ref readerCount63);
            }
            o.@Items = (global::System.Object[])ShrinkArray(a_0, ca_0, typeof(global::System.Object), true);
            ReadEndElement();
            return o;
        }

        protected override void InitCallbacks() {
        }

        string id48_ProviderTypeSource;
        string id37_KeywordListType;
        string id128_bitMap;
        string id114_helpLink;
        string id52_XmlTypeListType;
        string id70_keyword;
        string id28_ChannelListType;
        string id94_isolation;
        string id135_culture;
        string id140_fallbackCulture;
        string id137_string;
        string id136_stringTable;
        string id129_valueMap;
        string id19_StructDefinitionType;
        string id23_BitMapType;
        string id69_keywords;
        string id86_mask;
        string id7_EventsTypeMessageTableMessage;
        string id78_patternMap;
        string id54_MetadataType;
        string id61_name;
        string id88_eventGUID;
        string id79_format;
        string id40_LevelType;
        string id43_PatternMapValueType;
        string id47_TaskType;
        string id115_source;
        string id21_XmlType;
        string id118_maps;
        string id33_ChannelPublishingTypeSidType;
        string id74_xmlTypes;
        string id5_events;
        string id55_MetadataTypeMessage;
        string id117_filters;
        string id125_UserData;
        string id17_TemplateItemType;
        string id109_namespace;
        string id144_instrumentation;
        string id107_retention;
        string id112_messageFileName;
        string id84_outType;
        string id60_symbol;
        string id83_description;
        string id53_XmlTypeListTypeXmlType;
        string id9_StringTableTypeString;
        string id68_opcode;
        string id4_Item;
        string id56_InstrumentationManifestType;
        string id95_enabled;
        string id18_DataDefinitionType;
        string id2_Item;
        string id82_inType;
        string id49_InputTypeListType;
        string id1_instrumentationManifest;
        string id87_mofValue;
        string id139_stringType;
        string id81_xmlType;
        string id143_provider;
        string id67_opcodes;
        string id123_struct;
        string id59_message;
        string id3_InstrumentationType;
        string id130_filter;
        string id121_tid;
        string id63_levels;
        string id73_inTypes;
        string id103_latency;
        string id26_ValueMapValueType;
        string id65_tasks;
        string id77_patternMaps;
        string id142_EventsType;
        string id131_version;
        string id145_localization;
        string id14_DefinitionType;
        string id102_maxBuffers;
        string id8_StringTableType;
        string id10_LocalizationType;
        string id30_ChannelLoggingType;
        string id134_suppressProjection;
        string id44_OpcodeListType;
        string id85_default;
        string id75_namedQueries;
        string id41_NamedQueryType;
        string id124_binary;
        string id64_level;
        string id98_controlGuid;
        string id71_types;
        string id92_type;
        string id111_resourceFileName;
        string id34_ChannelTypeType;
        string id32_ChannelPublishingTypeClockType;
        string id133_notLogged;
        string id93_access;
        string id24_BitMapValueType;
        string id27_ProviderType;
        string id96_logging;
        string id138_id;
        string id62_channels;
        string id89_channel;
        string id80_map;
        string id120_template;
        string id29_ChannelType;
        string id122_data;
        string id106_autoBackup;
        string id104_clockType;
        string id101_minBuffers;
        string id127_length;
        string id91_chid;
        string id25_ValueMapType;
        string id16_TemplateListType;
        string id58_mid;
        string id35_ChannelTypeIsolation;
        string id113_parameterFileName;
        string id119_templates;
        string id110_guid;
        string id99_bufferSize;
        string id50_InputType;
        string id11_LocalizationTypeResources;
        string id132_event;
        string id57_value;
        string id51_OutputType;
        string id108_maxSize;
        string id38_KeywordType;
        string id46_TaskListType;
        string id22_MapType;
        string id42_PatternMapType;
        string id20_TemplateItemTypeBinary;
        string id31_ChannelPublishingType;
        string id90_importChannel;
        string id126_count;
        string id141_resources;
        string id146_metadata;
        string id100_fileMax;
        string id105_sidType;
        string id45_OpcodeType;
        string id72_XmlElement;
        string id6_EventsTypeMessageTable;
        string id13_FilterListType;
        string id76_messageTable;
        string id15_EventDefinitionType;
        string id97_publishing;
        string id66_task;
        string id39_LevelListType;
        string id116_Item;
        string id12_FilterType;
        string id36_ImportChannelType;

        protected override void InitIDs() {
            id48_ProviderTypeSource = Reader.NameTable.Add(@"ProviderTypeSource");
            id37_KeywordListType = Reader.NameTable.Add(@"KeywordListType");
            id128_bitMap = Reader.NameTable.Add(@"bitMap");
            id114_helpLink = Reader.NameTable.Add(@"helpLink");
            id52_XmlTypeListType = Reader.NameTable.Add(@"XmlTypeListType");
            id70_keyword = Reader.NameTable.Add(@"keyword");
            id28_ChannelListType = Reader.NameTable.Add(@"ChannelListType");
            id94_isolation = Reader.NameTable.Add(@"isolation");
            id135_culture = Reader.NameTable.Add(@"culture");
            id140_fallbackCulture = Reader.NameTable.Add(@"fallbackCulture");
            id137_string = Reader.NameTable.Add(@"string");
            id136_stringTable = Reader.NameTable.Add(@"stringTable");
            id129_valueMap = Reader.NameTable.Add(@"valueMap");
            id19_StructDefinitionType = Reader.NameTable.Add(@"StructDefinitionType");
            id23_BitMapType = Reader.NameTable.Add(@"BitMapType");
            id69_keywords = Reader.NameTable.Add(@"keywords");
            id86_mask = Reader.NameTable.Add(@"mask");
            id7_EventsTypeMessageTableMessage = Reader.NameTable.Add(@"EventsTypeMessageTableMessage");
            id78_patternMap = Reader.NameTable.Add(@"patternMap");
            id54_MetadataType = Reader.NameTable.Add(@"MetadataType");
            id61_name = Reader.NameTable.Add(@"name");
            id88_eventGUID = Reader.NameTable.Add(@"eventGUID");
            id79_format = Reader.NameTable.Add(@"format");
            id40_LevelType = Reader.NameTable.Add(@"LevelType");
            id43_PatternMapValueType = Reader.NameTable.Add(@"PatternMapValueType");
            id47_TaskType = Reader.NameTable.Add(@"TaskType");
            id115_source = Reader.NameTable.Add(@"source");
            id21_XmlType = Reader.NameTable.Add(@"XmlType");
            id118_maps = Reader.NameTable.Add(@"maps");
            id33_ChannelPublishingTypeSidType = Reader.NameTable.Add(@"ChannelPublishingTypeSidType");
            id74_xmlTypes = Reader.NameTable.Add(@"xmlTypes");
            id5_events = Reader.NameTable.Add(@"events");
            id55_MetadataTypeMessage = Reader.NameTable.Add(@"MetadataTypeMessage");
            id117_filters = Reader.NameTable.Add(@"filters");
            id125_UserData = Reader.NameTable.Add(@"UserData");
            id17_TemplateItemType = Reader.NameTable.Add(@"TemplateItemType");
            id109_namespace = Reader.NameTable.Add(@"namespace");
            id144_instrumentation = Reader.NameTable.Add(@"instrumentation");
            id107_retention = Reader.NameTable.Add(@"retention");
            id112_messageFileName = Reader.NameTable.Add(@"messageFileName");
            id84_outType = Reader.NameTable.Add(@"outType");
            id60_symbol = Reader.NameTable.Add(@"symbol");
            id83_description = Reader.NameTable.Add(@"description");
            id53_XmlTypeListTypeXmlType = Reader.NameTable.Add(@"XmlTypeListTypeXmlType");
            id9_StringTableTypeString = Reader.NameTable.Add(@"StringTableTypeString");
            id68_opcode = Reader.NameTable.Add(@"opcode");
            id4_Item = Reader.NameTable.Add(@"");
            id56_InstrumentationManifestType = Reader.NameTable.Add(@"InstrumentationManifestType");
            id95_enabled = Reader.NameTable.Add(@"enabled");
            id18_DataDefinitionType = Reader.NameTable.Add(@"DataDefinitionType");
            id2_Item = Reader.NameTable.Add(@"http://schemas.microsoft.com/win/2004/08/events");
            id82_inType = Reader.NameTable.Add(@"inType");
            id49_InputTypeListType = Reader.NameTable.Add(@"InputTypeListType");
            id1_instrumentationManifest = Reader.NameTable.Add(@"instrumentationManifest");
            id87_mofValue = Reader.NameTable.Add(@"mofValue");
            id139_stringType = Reader.NameTable.Add(@"stringType");
            id81_xmlType = Reader.NameTable.Add(@"xmlType");
            id143_provider = Reader.NameTable.Add(@"provider");
            id67_opcodes = Reader.NameTable.Add(@"opcodes");
            id123_struct = Reader.NameTable.Add(@"struct");
            id59_message = Reader.NameTable.Add(@"message");
            id3_InstrumentationType = Reader.NameTable.Add(@"InstrumentationType");
            id130_filter = Reader.NameTable.Add(@"filter");
            id121_tid = Reader.NameTable.Add(@"tid");
            id63_levels = Reader.NameTable.Add(@"levels");
            id73_inTypes = Reader.NameTable.Add(@"inTypes");
            id103_latency = Reader.NameTable.Add(@"latency");
            id26_ValueMapValueType = Reader.NameTable.Add(@"ValueMapValueType");
            id65_tasks = Reader.NameTable.Add(@"tasks");
            id77_patternMaps = Reader.NameTable.Add(@"patternMaps");
            id142_EventsType = Reader.NameTable.Add(@"EventsType");
            id131_version = Reader.NameTable.Add(@"version");
            id145_localization = Reader.NameTable.Add(@"localization");
            id14_DefinitionType = Reader.NameTable.Add(@"DefinitionType");
            id102_maxBuffers = Reader.NameTable.Add(@"maxBuffers");
            id8_StringTableType = Reader.NameTable.Add(@"StringTableType");
            id10_LocalizationType = Reader.NameTable.Add(@"LocalizationType");
            id30_ChannelLoggingType = Reader.NameTable.Add(@"ChannelLoggingType");
            id134_suppressProjection = Reader.NameTable.Add(@"suppressProjection");
            id44_OpcodeListType = Reader.NameTable.Add(@"OpcodeListType");
            id85_default = Reader.NameTable.Add(@"default");
            id75_namedQueries = Reader.NameTable.Add(@"namedQueries");
            id41_NamedQueryType = Reader.NameTable.Add(@"NamedQueryType");
            id124_binary = Reader.NameTable.Add(@"binary");
            id64_level = Reader.NameTable.Add(@"level");
            id98_controlGuid = Reader.NameTable.Add(@"controlGuid");
            id71_types = Reader.NameTable.Add(@"types");
            id92_type = Reader.NameTable.Add(@"type");
            id111_resourceFileName = Reader.NameTable.Add(@"resourceFileName");
            id34_ChannelTypeType = Reader.NameTable.Add(@"ChannelTypeType");
            id32_ChannelPublishingTypeClockType = Reader.NameTable.Add(@"ChannelPublishingTypeClockType");
            id133_notLogged = Reader.NameTable.Add(@"notLogged");
            id93_access = Reader.NameTable.Add(@"access");
            id24_BitMapValueType = Reader.NameTable.Add(@"BitMapValueType");
            id27_ProviderType = Reader.NameTable.Add(@"ProviderType");
            id96_logging = Reader.NameTable.Add(@"logging");
            id138_id = Reader.NameTable.Add(@"id");
            id62_channels = Reader.NameTable.Add(@"channels");
            id89_channel = Reader.NameTable.Add(@"channel");
            id80_map = Reader.NameTable.Add(@"map");
            id120_template = Reader.NameTable.Add(@"template");
            id29_ChannelType = Reader.NameTable.Add(@"ChannelType");
            id122_data = Reader.NameTable.Add(@"data");
            id106_autoBackup = Reader.NameTable.Add(@"autoBackup");
            id104_clockType = Reader.NameTable.Add(@"clockType");
            id101_minBuffers = Reader.NameTable.Add(@"minBuffers");
            id127_length = Reader.NameTable.Add(@"length");
            id91_chid = Reader.NameTable.Add(@"chid");
            id25_ValueMapType = Reader.NameTable.Add(@"ValueMapType");
            id16_TemplateListType = Reader.NameTable.Add(@"TemplateListType");
            id58_mid = Reader.NameTable.Add(@"mid");
            id35_ChannelTypeIsolation = Reader.NameTable.Add(@"ChannelTypeIsolation");
            id113_parameterFileName = Reader.NameTable.Add(@"parameterFileName");
            id119_templates = Reader.NameTable.Add(@"templates");
            id110_guid = Reader.NameTable.Add(@"guid");
            id99_bufferSize = Reader.NameTable.Add(@"bufferSize");
            id50_InputType = Reader.NameTable.Add(@"InputType");
            id11_LocalizationTypeResources = Reader.NameTable.Add(@"LocalizationTypeResources");
            id132_event = Reader.NameTable.Add(@"event");
            id57_value = Reader.NameTable.Add(@"value");
            id51_OutputType = Reader.NameTable.Add(@"OutputType");
            id108_maxSize = Reader.NameTable.Add(@"maxSize");
            id38_KeywordType = Reader.NameTable.Add(@"KeywordType");
            id46_TaskListType = Reader.NameTable.Add(@"TaskListType");
            id22_MapType = Reader.NameTable.Add(@"MapType");
            id42_PatternMapType = Reader.NameTable.Add(@"PatternMapType");
            id20_TemplateItemTypeBinary = Reader.NameTable.Add(@"TemplateItemTypeBinary");
            id31_ChannelPublishingType = Reader.NameTable.Add(@"ChannelPublishingType");
            id90_importChannel = Reader.NameTable.Add(@"importChannel");
            id126_count = Reader.NameTable.Add(@"count");
            id141_resources = Reader.NameTable.Add(@"resources");
            id146_metadata = Reader.NameTable.Add(@"metadata");
            id100_fileMax = Reader.NameTable.Add(@"fileMax");
            id105_sidType = Reader.NameTable.Add(@"sidType");
            id45_OpcodeType = Reader.NameTable.Add(@"OpcodeType");
            id72_XmlElement = Reader.NameTable.Add(@"XmlElement");
            id6_EventsTypeMessageTable = Reader.NameTable.Add(@"EventsTypeMessageTable");
            id13_FilterListType = Reader.NameTable.Add(@"FilterListType");
            id76_messageTable = Reader.NameTable.Add(@"messageTable");
            id15_EventDefinitionType = Reader.NameTable.Add(@"EventDefinitionType");
            id97_publishing = Reader.NameTable.Add(@"publishing");
            id66_task = Reader.NameTable.Add(@"task");
            id39_LevelListType = Reader.NameTable.Add(@"LevelListType");
            id116_Item = Reader.NameTable.Add(@"warnOnApplicationCompatibilityError");
            id12_FilterType = Reader.NameTable.Add(@"FilterType");
            id36_ImportChannelType = Reader.NameTable.Add(@"ImportChannelType");
        }
    }

    public abstract class XmlSerializer1 : System.Xml.Serialization.XmlSerializer {
        protected override System.Xml.Serialization.XmlSerializationReader CreateReader() {
            return new XmlSerializationReader1();
        }
        protected override System.Xml.Serialization.XmlSerializationWriter CreateWriter() {
            return new XmlSerializationWriter1();
        }
    }

    public sealed class instrumentationManifestSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"instrumentationManifest", @"http://schemas.microsoft.com/win/2004/08/events");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write68_instrumentationManifest(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read68_instrumentationManifest();
        }
    }

    public sealed class InstrumentationTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"InstrumentationType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write69_InstrumentationType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read69_InstrumentationType();
        }
    }

    public sealed class EventsTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"events", @"http://schemas.microsoft.com/win/2004/08/events");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write70_events(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read70_events();
        }
    }

    public sealed class EventsTypeMessageTableSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"EventsTypeMessageTable", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write71_EventsTypeMessageTable(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read71_EventsTypeMessageTable();
        }
    }

    public sealed class EventsTypeMessageTableMessageSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"EventsTypeMessageTableMessage", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write72_EventsTypeMessageTableMessage(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read72_EventsTypeMessageTableMessage();
        }
    }

    public sealed class StringTableTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"StringTableType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write73_StringTableType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read73_StringTableType();
        }
    }

    public sealed class StringTableTypeStringSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"StringTableTypeString", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write74_StringTableTypeString(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read74_StringTableTypeString();
        }
    }

    public sealed class LocalizationTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LocalizationType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write75_LocalizationType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read75_LocalizationType();
        }
    }

    public sealed class LocalizationTypeResourcesSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LocalizationTypeResources", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write76_LocalizationTypeResources(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read76_LocalizationTypeResources();
        }
    }

    public sealed class FilterTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"FilterType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write77_FilterType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read77_FilterType();
        }
    }

    public sealed class FilterListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"FilterListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write78_FilterListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read78_FilterListType();
        }
    }

    public sealed class DefinitionTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DefinitionType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write79_DefinitionType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read79_DefinitionType();
        }
    }

    public sealed class EventDefinitionTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"EventDefinitionType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write80_EventDefinitionType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read80_EventDefinitionType();
        }
    }

    public sealed class TemplateListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TemplateListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write81_TemplateListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read81_TemplateListType();
        }
    }

    public sealed class TemplateItemTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TemplateItemType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write82_TemplateItemType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read82_TemplateItemType();
        }
    }

    public sealed class DataDefinitionTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"DataDefinitionType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write83_DataDefinitionType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read83_DataDefinitionType();
        }
    }

    public sealed class StructDefinitionTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"StructDefinitionType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write84_StructDefinitionType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read84_StructDefinitionType();
        }
    }

    public sealed class TemplateItemTypeBinarySerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TemplateItemTypeBinary", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write85_TemplateItemTypeBinary(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read85_TemplateItemTypeBinary();
        }
    }

    public sealed class XmlTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"XmlType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write86_XmlType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read86_XmlType();
        }
    }

    public sealed class MapTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"MapType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write87_MapType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read87_MapType();
        }
    }

    public sealed class BitMapTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"BitMapType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write88_BitMapType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read88_BitMapType();
        }
    }

    public sealed class BitMapValueTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"BitMapValueType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write89_BitMapValueType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read89_BitMapValueType();
        }
    }

    public sealed class ValueMapTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ValueMapType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write90_ValueMapType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read90_ValueMapType();
        }
    }

    public sealed class ValueMapValueTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ValueMapValueType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write91_ValueMapValueType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read91_ValueMapValueType();
        }
    }

    public sealed class ProviderTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ProviderType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write92_ProviderType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read92_ProviderType();
        }
    }

    public sealed class ChannelListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write93_ChannelListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read93_ChannelListType();
        }
    }

    public sealed class ChannelTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write94_ChannelType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read94_ChannelType();
        }
    }

    public sealed class ChannelLoggingTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelLoggingType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write95_ChannelLoggingType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read95_ChannelLoggingType();
        }
    }

    public sealed class ChannelPublishingTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelPublishingType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write96_ChannelPublishingType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read96_ChannelPublishingType();
        }
    }

    public sealed class ChannelPublishingTypeClockTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelPublishingTypeClockType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write97_ChannelPublishingTypeClockType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read97_ChannelPublishingTypeClockType();
        }
    }

    public sealed class ChannelPublishingTypeSidTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelPublishingTypeSidType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write98_ChannelPublishingTypeSidType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read98_ChannelPublishingTypeSidType();
        }
    }

    public sealed class ChannelTypeTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelTypeType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write99_ChannelTypeType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read99_ChannelTypeType();
        }
    }

    public sealed class ChannelTypeIsolationSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ChannelTypeIsolation", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write100_ChannelTypeIsolation(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read100_ChannelTypeIsolation();
        }
    }

    public sealed class ImportChannelTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ImportChannelType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write101_ImportChannelType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read101_ImportChannelType();
        }
    }

    public sealed class KeywordListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"KeywordListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write102_KeywordListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read102_KeywordListType();
        }
    }

    public sealed class KeywordTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"KeywordType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write103_KeywordType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read103_KeywordType();
        }
    }

    public sealed class LevelListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LevelListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write104_LevelListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read104_LevelListType();
        }
    }

    public sealed class LevelTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"LevelType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write105_LevelType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read105_LevelType();
        }
    }

    public sealed class NamedQueryTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"NamedQueryType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write106_NamedQueryType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read106_NamedQueryType();
        }
    }

    public sealed class PatternMapTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PatternMapType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write107_PatternMapType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read107_PatternMapType();
        }
    }

    public sealed class PatternMapValueTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"PatternMapValueType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write108_PatternMapValueType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read108_PatternMapValueType();
        }
    }

    public sealed class OpcodeListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"OpcodeListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write109_OpcodeListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read109_OpcodeListType();
        }
    }

    public sealed class OpcodeTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"OpcodeType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write110_OpcodeType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read110_OpcodeType();
        }
    }

    public sealed class TaskListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TaskListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write111_TaskListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read111_TaskListType();
        }
    }

    public sealed class TaskTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"TaskType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write112_TaskType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read112_TaskType();
        }
    }

    public sealed class ProviderTypeSourceSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"ProviderTypeSource", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write113_ProviderTypeSource(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read113_ProviderTypeSource();
        }
    }

    public sealed class InputTypeListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"InputTypeListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write114_InputTypeListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read114_InputTypeListType();
        }
    }

    public sealed class InputTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"InputType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write115_InputType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read115_InputType();
        }
    }

    public sealed class OutputTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"OutputType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write116_OutputType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read116_OutputType();
        }
    }

    public sealed class XmlTypeListTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"XmlTypeListType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write117_XmlTypeListType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read117_XmlTypeListType();
        }
    }

    public sealed class XmlTypeListTypeXmlTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"XmlTypeListTypeXmlType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write118_XmlTypeListTypeXmlType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read118_XmlTypeListTypeXmlType();
        }
    }

    public sealed class MetadataTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"MetadataType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write119_MetadataType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read119_MetadataType();
        }
    }

    public sealed class MetadataTypeMessageSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"MetadataTypeMessage", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write120_MetadataTypeMessage(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read120_MetadataTypeMessage();
        }
    }

    public sealed class InstrumentationManifestTypeSerializer : XmlSerializer1 {

        public override System.Boolean CanDeserialize(System.Xml.XmlReader xmlReader) {
            return xmlReader.IsStartElement(@"InstrumentationManifestType", @"");
        }

        protected override void Serialize(object objectToSerialize, System.Xml.Serialization.XmlSerializationWriter writer) {
            ((XmlSerializationWriter1)writer).Write121_InstrumentationManifestType(objectToSerialize);
        }

        protected override object Deserialize(System.Xml.Serialization.XmlSerializationReader reader) {
            return ((XmlSerializationReader1)reader).Read121_InstrumentationManifestType();
        }
    }

    public class XmlSerializerContract : global::System.Xml.Serialization.XmlSerializerImplementation {
        public override global::System.Xml.Serialization.XmlSerializationReader Reader { get { return new XmlSerializationReader1(); } }
        public override global::System.Xml.Serialization.XmlSerializationWriter Writer { get { return new XmlSerializationWriter1(); } }
        System.Collections.Hashtable readMethods = null;
        public override System.Collections.Hashtable ReadMethods {
            get {
                if (readMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"instrumentationManifest:http://schemas.microsoft.com/win/2004/08/events::False:"] = @"Read68_instrumentationManifest";
                    _tmp[@"InstrumentationType::"] = @"Read69_InstrumentationType";
                    _tmp[@"EventsType:http://schemas.microsoft.com/win/2004/08/events:events:False:"] = @"Read70_events";
                    _tmp[@"EventsTypeMessageTable::"] = @"Read71_EventsTypeMessageTable";
                    _tmp[@"EventsTypeMessageTableMessage::"] = @"Read72_EventsTypeMessageTableMessage";
                    _tmp[@"StringTableType::"] = @"Read73_StringTableType";
                    _tmp[@"StringTableTypeString::"] = @"Read74_StringTableTypeString";
                    _tmp[@"LocalizationType::"] = @"Read75_LocalizationType";
                    _tmp[@"LocalizationTypeResources::"] = @"Read76_LocalizationTypeResources";
                    _tmp[@"FilterType::"] = @"Read77_FilterType";
                    _tmp[@"FilterListType::"] = @"Read78_FilterListType";
                    _tmp[@"DefinitionType::"] = @"Read79_DefinitionType";
                    _tmp[@"EventDefinitionType::"] = @"Read80_EventDefinitionType";
                    _tmp[@"TemplateListType::"] = @"Read81_TemplateListType";
                    _tmp[@"TemplateItemType::"] = @"Read82_TemplateItemType";
                    _tmp[@"DataDefinitionType::"] = @"Read83_DataDefinitionType";
                    _tmp[@"StructDefinitionType::"] = @"Read84_StructDefinitionType";
                    _tmp[@"TemplateItemTypeBinary::"] = @"Read85_TemplateItemTypeBinary";
                    _tmp[@"XmlType::"] = @"Read86_XmlType";
                    _tmp[@"MapType::"] = @"Read87_MapType";
                    _tmp[@"BitMapType::"] = @"Read88_BitMapType";
                    _tmp[@"BitMapValueType::"] = @"Read89_BitMapValueType";
                    _tmp[@"ValueMapType::"] = @"Read90_ValueMapType";
                    _tmp[@"ValueMapValueType::"] = @"Read91_ValueMapValueType";
                    _tmp[@"ProviderType::"] = @"Read92_ProviderType";
                    _tmp[@"ChannelListType::"] = @"Read93_ChannelListType";
                    _tmp[@"ChannelType::"] = @"Read94_ChannelType";
                    _tmp[@"ChannelLoggingType::"] = @"Read95_ChannelLoggingType";
                    _tmp[@"ChannelPublishingType::"] = @"Read96_ChannelPublishingType";
                    _tmp[@"ChannelPublishingTypeClockType::"] = @"Read97_ChannelPublishingTypeClockType";
                    _tmp[@"ChannelPublishingTypeSidType::"] = @"Read98_ChannelPublishingTypeSidType";
                    _tmp[@"ChannelTypeType::"] = @"Read99_ChannelTypeType";
                    _tmp[@"ChannelTypeIsolation::"] = @"Read100_ChannelTypeIsolation";
                    _tmp[@"ImportChannelType::"] = @"Read101_ImportChannelType";
                    _tmp[@"KeywordListType::"] = @"Read102_KeywordListType";
                    _tmp[@"KeywordType::"] = @"Read103_KeywordType";
                    _tmp[@"LevelListType::"] = @"Read104_LevelListType";
                    _tmp[@"LevelType::"] = @"Read105_LevelType";
                    _tmp[@"NamedQueryType::"] = @"Read106_NamedQueryType";
                    _tmp[@"PatternMapType::"] = @"Read107_PatternMapType";
                    _tmp[@"PatternMapValueType::"] = @"Read108_PatternMapValueType";
                    _tmp[@"OpcodeListType::"] = @"Read109_OpcodeListType";
                    _tmp[@"OpcodeType::"] = @"Read110_OpcodeType";
                    _tmp[@"TaskListType::"] = @"Read111_TaskListType";
                    _tmp[@"TaskType::"] = @"Read112_TaskType";
                    _tmp[@"ProviderTypeSource::"] = @"Read113_ProviderTypeSource";
                    _tmp[@"InputTypeListType::"] = @"Read114_InputTypeListType";
                    _tmp[@"InputType::"] = @"Read115_InputType";
                    _tmp[@"OutputType::"] = @"Read116_OutputType";
                    _tmp[@"XmlTypeListType::"] = @"Read117_XmlTypeListType";
                    _tmp[@"XmlTypeListTypeXmlType::"] = @"Read118_XmlTypeListTypeXmlType";
                    _tmp[@"MetadataType::"] = @"Read119_MetadataType";
                    _tmp[@"MetadataTypeMessage::"] = @"Read120_MetadataTypeMessage";
                    _tmp[@"InstrumentationManifestType::"] = @"Read121_InstrumentationManifestType";
                    if (readMethods == null) readMethods = _tmp;
                }
                return readMethods;
            }
        }
        System.Collections.Hashtable writeMethods = null;
        public override System.Collections.Hashtable WriteMethods {
            get {
                if (writeMethods == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp[@"instrumentationManifest:http://schemas.microsoft.com/win/2004/08/events::False:"] = @"Write68_instrumentationManifest";
                    _tmp[@"InstrumentationType::"] = @"Write69_InstrumentationType";
                    _tmp[@"EventsType:http://schemas.microsoft.com/win/2004/08/events:events:False:"] = @"Write70_events";
                    _tmp[@"EventsTypeMessageTable::"] = @"Write71_EventsTypeMessageTable";
                    _tmp[@"EventsTypeMessageTableMessage::"] = @"Write72_EventsTypeMessageTableMessage";
                    _tmp[@"StringTableType::"] = @"Write73_StringTableType";
                    _tmp[@"StringTableTypeString::"] = @"Write74_StringTableTypeString";
                    _tmp[@"LocalizationType::"] = @"Write75_LocalizationType";
                    _tmp[@"LocalizationTypeResources::"] = @"Write76_LocalizationTypeResources";
                    _tmp[@"FilterType::"] = @"Write77_FilterType";
                    _tmp[@"FilterListType::"] = @"Write78_FilterListType";
                    _tmp[@"DefinitionType::"] = @"Write79_DefinitionType";
                    _tmp[@"EventDefinitionType::"] = @"Write80_EventDefinitionType";
                    _tmp[@"TemplateListType::"] = @"Write81_TemplateListType";
                    _tmp[@"TemplateItemType::"] = @"Write82_TemplateItemType";
                    _tmp[@"DataDefinitionType::"] = @"Write83_DataDefinitionType";
                    _tmp[@"StructDefinitionType::"] = @"Write84_StructDefinitionType";
                    _tmp[@"TemplateItemTypeBinary::"] = @"Write85_TemplateItemTypeBinary";
                    _tmp[@"XmlType::"] = @"Write86_XmlType";
                    _tmp[@"MapType::"] = @"Write87_MapType";
                    _tmp[@"BitMapType::"] = @"Write88_BitMapType";
                    _tmp[@"BitMapValueType::"] = @"Write89_BitMapValueType";
                    _tmp[@"ValueMapType::"] = @"Write90_ValueMapType";
                    _tmp[@"ValueMapValueType::"] = @"Write91_ValueMapValueType";
                    _tmp[@"ProviderType::"] = @"Write92_ProviderType";
                    _tmp[@"ChannelListType::"] = @"Write93_ChannelListType";
                    _tmp[@"ChannelType::"] = @"Write94_ChannelType";
                    _tmp[@"ChannelLoggingType::"] = @"Write95_ChannelLoggingType";
                    _tmp[@"ChannelPublishingType::"] = @"Write96_ChannelPublishingType";
                    _tmp[@"ChannelPublishingTypeClockType::"] = @"Write97_ChannelPublishingTypeClockType";
                    _tmp[@"ChannelPublishingTypeSidType::"] = @"Write98_ChannelPublishingTypeSidType";
                    _tmp[@"ChannelTypeType::"] = @"Write99_ChannelTypeType";
                    _tmp[@"ChannelTypeIsolation::"] = @"Write100_ChannelTypeIsolation";
                    _tmp[@"ImportChannelType::"] = @"Write101_ImportChannelType";
                    _tmp[@"KeywordListType::"] = @"Write102_KeywordListType";
                    _tmp[@"KeywordType::"] = @"Write103_KeywordType";
                    _tmp[@"LevelListType::"] = @"Write104_LevelListType";
                    _tmp[@"LevelType::"] = @"Write105_LevelType";
                    _tmp[@"NamedQueryType::"] = @"Write106_NamedQueryType";
                    _tmp[@"PatternMapType::"] = @"Write107_PatternMapType";
                    _tmp[@"PatternMapValueType::"] = @"Write108_PatternMapValueType";
                    _tmp[@"OpcodeListType::"] = @"Write109_OpcodeListType";
                    _tmp[@"OpcodeType::"] = @"Write110_OpcodeType";
                    _tmp[@"TaskListType::"] = @"Write111_TaskListType";
                    _tmp[@"TaskType::"] = @"Write112_TaskType";
                    _tmp[@"ProviderTypeSource::"] = @"Write113_ProviderTypeSource";
                    _tmp[@"InputTypeListType::"] = @"Write114_InputTypeListType";
                    _tmp[@"InputType::"] = @"Write115_InputType";
                    _tmp[@"OutputType::"] = @"Write116_OutputType";
                    _tmp[@"XmlTypeListType::"] = @"Write117_XmlTypeListType";
                    _tmp[@"XmlTypeListTypeXmlType::"] = @"Write118_XmlTypeListTypeXmlType";
                    _tmp[@"MetadataType::"] = @"Write119_MetadataType";
                    _tmp[@"MetadataTypeMessage::"] = @"Write120_MetadataTypeMessage";
                    _tmp[@"InstrumentationManifestType::"] = @"Write121_InstrumentationManifestType";
                    if (writeMethods == null) writeMethods = _tmp;
                }
                return writeMethods;
            }
        }
        System.Collections.Hashtable typedSerializers = null;
        public override System.Collections.Hashtable TypedSerializers {
            get {
                if (typedSerializers == null) {
                    System.Collections.Hashtable _tmp = new System.Collections.Hashtable();
                    _tmp.Add(@"StringTableType::", new StringTableTypeSerializer());
                    _tmp.Add(@"ChannelType::", new ChannelTypeSerializer());
                    _tmp.Add(@"DefinitionType::", new DefinitionTypeSerializer());
                    _tmp.Add(@"LocalizationType::", new LocalizationTypeSerializer());
                    _tmp.Add(@"DataDefinitionType::", new DataDefinitionTypeSerializer());
                    _tmp.Add(@"XmlTypeListTypeXmlType::", new XmlTypeListTypeXmlTypeSerializer());
                    _tmp.Add(@"EventsType:http://schemas.microsoft.com/win/2004/08/events:events:False:", new EventsTypeSerializer());
                    _tmp.Add(@"MetadataType::", new MetadataTypeSerializer());
                    _tmp.Add(@"OutputType::", new OutputTypeSerializer());
                    _tmp.Add(@"MapType::", new MapTypeSerializer());
                    _tmp.Add(@"InstrumentationType::", new InstrumentationTypeSerializer());
                    _tmp.Add(@"ChannelListType::", new ChannelListTypeSerializer());
                    _tmp.Add(@"ValueMapType::", new ValueMapTypeSerializer());
                    _tmp.Add(@"FilterListType::", new FilterListTypeSerializer());
                    _tmp.Add(@"ImportChannelType::", new ImportChannelTypeSerializer());
                    _tmp.Add(@"PatternMapType::", new PatternMapTypeSerializer());
                    _tmp.Add(@"ChannelPublishingType::", new ChannelPublishingTypeSerializer());
                    _tmp.Add(@"StructDefinitionType::", new StructDefinitionTypeSerializer());
                    _tmp.Add(@"ChannelPublishingTypeSidType::", new ChannelPublishingTypeSidTypeSerializer());
                    _tmp.Add(@"EventsTypeMessageTableMessage::", new EventsTypeMessageTableMessageSerializer());
                    _tmp.Add(@"KeywordListType::", new KeywordListTypeSerializer());
                    _tmp.Add(@"XmlType::", new XmlTypeSerializer());
                    _tmp.Add(@"TaskType::", new TaskTypeSerializer());
                    _tmp.Add(@"BitMapValueType::", new BitMapValueTypeSerializer());
                    _tmp.Add(@"LocalizationTypeResources::", new LocalizationTypeResourcesSerializer());
                    _tmp.Add(@"ProviderTypeSource::", new ProviderTypeSourceSerializer());
                    _tmp.Add(@"LevelListType::", new LevelListTypeSerializer());
                    _tmp.Add(@"EventDefinitionType::", new EventDefinitionTypeSerializer());
                    _tmp.Add(@"InputTypeListType::", new InputTypeListTypeSerializer());
                    _tmp.Add(@"LevelType::", new LevelTypeSerializer());
                    _tmp.Add(@"OpcodeType::", new OpcodeTypeSerializer());
                    _tmp.Add(@"FilterType::", new FilterTypeSerializer());
                    _tmp.Add(@"ValueMapValueType::", new ValueMapValueTypeSerializer());
                    _tmp.Add(@"KeywordType::", new KeywordTypeSerializer());
                    _tmp.Add(@"BitMapType::", new BitMapTypeSerializer());
                    _tmp.Add(@"ChannelPublishingTypeClockType::", new ChannelPublishingTypeClockTypeSerializer());
                    _tmp.Add(@"XmlTypeListType::", new XmlTypeListTypeSerializer());
                    _tmp.Add(@"InstrumentationManifestType::", new InstrumentationManifestTypeSerializer());
                    _tmp.Add(@"NamedQueryType::", new NamedQueryTypeSerializer());
                    _tmp.Add(@"ChannelLoggingType::", new ChannelLoggingTypeSerializer());
                    _tmp.Add(@"TemplateItemType::", new TemplateItemTypeSerializer());
                    _tmp.Add(@"StringTableTypeString::", new StringTableTypeStringSerializer());
                    _tmp.Add(@"ChannelTypeType::", new ChannelTypeTypeSerializer());
                    _tmp.Add(@"ProviderType::", new ProviderTypeSerializer());
                    _tmp.Add(@"PatternMapValueType::", new PatternMapValueTypeSerializer());
                    _tmp.Add(@"instrumentationManifest:http://schemas.microsoft.com/win/2004/08/events::False:", new instrumentationManifestSerializer());
                    _tmp.Add(@"EventsTypeMessageTable::", new EventsTypeMessageTableSerializer());
                    _tmp.Add(@"InputType::", new InputTypeSerializer());
                    _tmp.Add(@"MetadataTypeMessage::", new MetadataTypeMessageSerializer());
                    _tmp.Add(@"TaskListType::", new TaskListTypeSerializer());
                    _tmp.Add(@"TemplateListType::", new TemplateListTypeSerializer());
                    _tmp.Add(@"ChannelTypeIsolation::", new ChannelTypeIsolationSerializer());
                    _tmp.Add(@"TemplateItemTypeBinary::", new TemplateItemTypeBinarySerializer());
                    _tmp.Add(@"OpcodeListType::", new OpcodeListTypeSerializer());
                    if (typedSerializers == null) typedSerializers = _tmp;
                }
                return typedSerializers;
            }
        }
        public override System.Boolean CanSerialize(System.Type type) {
            if (type == typeof(global::instrumentationManifest)) return true;
            if (type == typeof(global::InstrumentationType)) return true;
            if (type == typeof(global::EventsType)) return true;
            if (type == typeof(global::EventsTypeMessageTable)) return true;
            if (type == typeof(global::EventsTypeMessageTableMessage)) return true;
            if (type == typeof(global::StringTableType)) return true;
            if (type == typeof(global::StringTableTypeString)) return true;
            if (type == typeof(global::LocalizationType)) return true;
            if (type == typeof(global::LocalizationTypeResources)) return true;
            if (type == typeof(global::FilterType)) return true;
            if (type == typeof(global::FilterListType)) return true;
            if (type == typeof(global::DefinitionType)) return true;
            if (type == typeof(global::EventDefinitionType)) return true;
            if (type == typeof(global::TemplateListType)) return true;
            if (type == typeof(global::TemplateItemType)) return true;
            if (type == typeof(global::DataDefinitionType)) return true;
            if (type == typeof(global::StructDefinitionType)) return true;
            if (type == typeof(global::TemplateItemTypeBinary)) return true;
            if (type == typeof(global::XmlType)) return true;
            if (type == typeof(global::MapType)) return true;
            if (type == typeof(global::BitMapType)) return true;
            if (type == typeof(global::BitMapValueType)) return true;
            if (type == typeof(global::ValueMapType)) return true;
            if (type == typeof(global::ValueMapValueType)) return true;
            if (type == typeof(global::ProviderType)) return true;
            if (type == typeof(global::ChannelListType)) return true;
            if (type == typeof(global::ChannelType)) return true;
            if (type == typeof(global::ChannelLoggingType)) return true;
            if (type == typeof(global::ChannelPublishingType)) return true;
            if (type == typeof(global::ChannelPublishingTypeClockType)) return true;
            if (type == typeof(global::ChannelPublishingTypeSidType)) return true;
            if (type == typeof(global::ChannelTypeType)) return true;
            if (type == typeof(global::ChannelTypeIsolation)) return true;
            if (type == typeof(global::ImportChannelType)) return true;
            if (type == typeof(global::KeywordListType)) return true;
            if (type == typeof(global::KeywordType)) return true;
            if (type == typeof(global::LevelListType)) return true;
            if (type == typeof(global::LevelType)) return true;
            if (type == typeof(global::NamedQueryType)) return true;
            if (type == typeof(global::PatternMapType)) return true;
            if (type == typeof(global::PatternMapValueType)) return true;
            if (type == typeof(global::OpcodeListType)) return true;
            if (type == typeof(global::OpcodeType)) return true;
            if (type == typeof(global::TaskListType)) return true;
            if (type == typeof(global::TaskType)) return true;
            if (type == typeof(global::ProviderTypeSource)) return true;
            if (type == typeof(global::InputTypeListType)) return true;
            if (type == typeof(global::InputType)) return true;
            if (type == typeof(global::OutputType)) return true;
            if (type == typeof(global::XmlTypeListType)) return true;
            if (type == typeof(global::XmlTypeListTypeXmlType)) return true;
            if (type == typeof(global::MetadataType)) return true;
            if (type == typeof(global::MetadataTypeMessage)) return true;
            if (type == typeof(global::InstrumentationManifestType)) return true;
            return false;
        }
        public override System.Xml.Serialization.XmlSerializer GetSerializer(System.Type type) {
            if (type == typeof(global::instrumentationManifest)) return new instrumentationManifestSerializer();
            if (type == typeof(global::InstrumentationType)) return new InstrumentationTypeSerializer();
            if (type == typeof(global::EventsType)) return new EventsTypeSerializer();
            if (type == typeof(global::EventsTypeMessageTable)) return new EventsTypeMessageTableSerializer();
            if (type == typeof(global::EventsTypeMessageTableMessage)) return new EventsTypeMessageTableMessageSerializer();
            if (type == typeof(global::StringTableType)) return new StringTableTypeSerializer();
            if (type == typeof(global::StringTableTypeString)) return new StringTableTypeStringSerializer();
            if (type == typeof(global::LocalizationType)) return new LocalizationTypeSerializer();
            if (type == typeof(global::LocalizationTypeResources)) return new LocalizationTypeResourcesSerializer();
            if (type == typeof(global::FilterType)) return new FilterTypeSerializer();
            if (type == typeof(global::FilterListType)) return new FilterListTypeSerializer();
            if (type == typeof(global::DefinitionType)) return new DefinitionTypeSerializer();
            if (type == typeof(global::EventDefinitionType)) return new EventDefinitionTypeSerializer();
            if (type == typeof(global::TemplateListType)) return new TemplateListTypeSerializer();
            if (type == typeof(global::TemplateItemType)) return new TemplateItemTypeSerializer();
            if (type == typeof(global::DataDefinitionType)) return new DataDefinitionTypeSerializer();
            if (type == typeof(global::StructDefinitionType)) return new StructDefinitionTypeSerializer();
            if (type == typeof(global::TemplateItemTypeBinary)) return new TemplateItemTypeBinarySerializer();
            if (type == typeof(global::XmlType)) return new XmlTypeSerializer();
            if (type == typeof(global::MapType)) return new MapTypeSerializer();
            if (type == typeof(global::BitMapType)) return new BitMapTypeSerializer();
            if (type == typeof(global::BitMapValueType)) return new BitMapValueTypeSerializer();
            if (type == typeof(global::ValueMapType)) return new ValueMapTypeSerializer();
            if (type == typeof(global::ValueMapValueType)) return new ValueMapValueTypeSerializer();
            if (type == typeof(global::ProviderType)) return new ProviderTypeSerializer();
            if (type == typeof(global::ChannelListType)) return new ChannelListTypeSerializer();
            if (type == typeof(global::ChannelType)) return new ChannelTypeSerializer();
            if (type == typeof(global::ChannelLoggingType)) return new ChannelLoggingTypeSerializer();
            if (type == typeof(global::ChannelPublishingType)) return new ChannelPublishingTypeSerializer();
            if (type == typeof(global::ChannelPublishingTypeClockType)) return new ChannelPublishingTypeClockTypeSerializer();
            if (type == typeof(global::ChannelPublishingTypeSidType)) return new ChannelPublishingTypeSidTypeSerializer();
            if (type == typeof(global::ChannelTypeType)) return new ChannelTypeTypeSerializer();
            if (type == typeof(global::ChannelTypeIsolation)) return new ChannelTypeIsolationSerializer();
            if (type == typeof(global::ImportChannelType)) return new ImportChannelTypeSerializer();
            if (type == typeof(global::KeywordListType)) return new KeywordListTypeSerializer();
            if (type == typeof(global::KeywordType)) return new KeywordTypeSerializer();
            if (type == typeof(global::LevelListType)) return new LevelListTypeSerializer();
            if (type == typeof(global::LevelType)) return new LevelTypeSerializer();
            if (type == typeof(global::NamedQueryType)) return new NamedQueryTypeSerializer();
            if (type == typeof(global::PatternMapType)) return new PatternMapTypeSerializer();
            if (type == typeof(global::PatternMapValueType)) return new PatternMapValueTypeSerializer();
            if (type == typeof(global::OpcodeListType)) return new OpcodeListTypeSerializer();
            if (type == typeof(global::OpcodeType)) return new OpcodeTypeSerializer();
            if (type == typeof(global::TaskListType)) return new TaskListTypeSerializer();
            if (type == typeof(global::TaskType)) return new TaskTypeSerializer();
            if (type == typeof(global::ProviderTypeSource)) return new ProviderTypeSourceSerializer();
            if (type == typeof(global::InputTypeListType)) return new InputTypeListTypeSerializer();
            if (type == typeof(global::InputType)) return new InputTypeSerializer();
            if (type == typeof(global::OutputType)) return new OutputTypeSerializer();
            if (type == typeof(global::XmlTypeListType)) return new XmlTypeListTypeSerializer();
            if (type == typeof(global::XmlTypeListTypeXmlType)) return new XmlTypeListTypeXmlTypeSerializer();
            if (type == typeof(global::MetadataType)) return new MetadataTypeSerializer();
            if (type == typeof(global::MetadataTypeMessage)) return new MetadataTypeMessageSerializer();
            if (type == typeof(global::InstrumentationManifestType)) return new InstrumentationManifestTypeSerializer();
            return null;
        }
    }
}
