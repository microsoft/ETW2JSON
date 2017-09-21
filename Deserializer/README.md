# ETWDeserializer

ETWDeserializer is a general-purpose Windows ETW event deserialization library. It can decode events from almost all sources of Windows including the Kernel (MOF Classes), Manifest events (those available beyond Windows Vista), XPERF performance profiling events, and .NET EventSource-style events.

**NOTE**: This is a support library, i.e. the user of this library must setup the boiler-plate code involved in setting up an ETW Session or reading an ETW log file (.ETL). [**ETW2JSON**](http://github.com/ETWTools/ETW2JSON) and [**ETW2SQLite**](http://github.com/ETWTools/ETW2SQLite) are two such applications.

## Usage

Implement the ``IEtwWriter`` interface exposed by the library and add boiler plate code to set up an ETW event session or reading from an ETW log file (.ETL)

[**ETW2JSON**](http://github.com/ETWTools/ETW2JSON) and [**ETW2SQLite**](http://github.com/ETWTools/ETW2SQLite) each implement their own ``IEtwWriter`` and also the code involved in reading an ETW log file from disk.

## Nuget package

This library is available on Nuget -- https://www.nuget.org/packages/ETWDeserializer/1.2.0

## Building ETWDeserializer

Since this is a Windows-specific library, I'm assuming you're also building on Windows and have MSBuild Tools installed, in which case:

``msbuild ETWDeserializer.csproj``

is all you need to do.