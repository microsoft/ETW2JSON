# ETW2JSON

ETW2JSON is a tool that converts ETW Log Files (.ETL) to JSON using the Newtonsoft.Json library. It can be used as a stand-alone command line tool that will take as input locations of ETL files and an output path, or it can take your implementation of Newtonsoft.Json's ``JsonWriter`` class.

## Library usage

``ConvertToJson(JsonWriter jsonWriter, IEnumerable<string> inputFiles, Action<string> reportError)``

## Command-line usage

``ETW2JSON C:\MyFile.etl C:\MyFile.Kernel.etl --output=C:\MyFile.json``

## Nuget package

This library is available on Nuget -- https://www.nuget.org/packages/ETW2JSON/1.3.10

## Why JSON?

Converting ETW Log Files (.ETL) to JSON makes accessible to you a plethora of data that was previously restricted to expert ETW tools or libraries. The goal of this tool is to make ETW data more accessible to a larger developer and operations audience by converting to a human-readable format that is ubiquitous.

## Motivational use-case + workflow for collecting data and using ETW2JSON

**Background**: You are a devops team running a cloud service on Windows that runs .NET code, and you log some of your data using .NET EventSource. Other parts of your code write JSON to disk directly. Furthermore you are also interested in seeing data from Windows and the .NET CLR interspersed with your own logging data.

**Pick your ETW Collection tool**: [Microsoft TraceEvent](https://www.nuget.org/packages/Microsoft.Diagnostics.Tracing.TraceEvent/), plain old ``logman`` from the Windows command line.

Now you have an ETL file, or a set of ETL files, and maybe this set of ETL files is continous, considering you are cloud service.

After your collection is done, you can use ETW2JSON to convert the ETL file to JSON as follows:

``ETW2JSON myFile.etl --output=myFile.json``

You can now view this data in a variety of JSON log viewers, merge it with your own non-ETW event sources, push the data to a cloud logmerge system (Kafka, ElasticSearch, etc.) or store it in your [favorite JSON database](http://www.postgresql.org).


## Does it understand Kernel, .NET EventSource, XPERF, etc. events?

ETW2JSON is a library that understands Windows MOF Classes events, Windows Vista Manifest events and EventSource .NET events. It also understands events that XPERF (WPR) adds as part of its merging process (to give PDB information) for profiler tools like the Windows Performance Recorder.

## Example output

This is the output of ETW2JSON for a single event record of type ``CLRTrace/CLR Method/MethodDCEndVerbose`` -- you can use your favorite JSON Viewer to view this data.

```json
{
   "CLRTrace/CLR Method/MethodDCEndVerbose":[
      {
         "MethodIdentifier":140712944189680,
         "ModuleID":140712943752376,
         "MethodStartAddress":140712947662480,
         "MethodSize":174,
         "MethodToken":100669671,
         "MethodFlags":0,
         "MethodNameSpace":"System.Xml.Schema.SchemaCollectionCompiler",
         "Methodname":"CompileGroup",
         "MethodSig":"instance void  (class System.Xml.Schema.XmlSchemaGroup)"
      }
   ]
}
```

## Microsoft Open Source Code of Conduct

This project has adopted the [Microsoft Open Source Code of Conduct](https://opensource.microsoft.com/codeofconduct/). For more information see the [Code of Conduct FAQ](https://opensource.microsoft.com/codeofconduct/faq/) or contact [opencode@microsoft.com](mailto:opencode@microsoft.com) with any additional questions or comments.