# Quick Start - NEXT Serialization

Print messages for the NEXT platform are persisted as XML files.  The NEXT Serialization library is intended to help
customers who wish to automate the creation or alteration of their own custom print messages that are compatible 
with the NEXT platform.

This quick start will help you get up and running with NEXT Message serialization by showing
some basic usage examples.  This tutorial assumes that the reader is experienced with .NET software
development, using development environments like [Visual Studio](https://visualstudio.microsoft.com/downloads/), 
as well as tools like [NuGet.org](https://www.nuget.org/downloads).

## Prerequisites

- A functioning installation of the .NET 6 (or higher) runtime and SDK
- A development environment such as [Visual Studio](https://visualstudio.microsoft.com/downloads/) or [VS Code](https://code.visualstudio.com/?wt.mc_id=vscom_downloads)
- A working version of NuGet
    - Provided by the Visual Studio installation  
    or
    - The latest version from [NuGet.org](https://www.nuget.org/downloads)

### Create a .NET Console App
1. Create a directory for your project.
1. From that directory, enter the following command:

```
dotnet new console --framework net6.0
```

### Install NEXTSerialization NuGet Package

From the project directory, enter the following command:

```
dotnet add package NextSerialization --version 1.0.1
```

## Deserialize NEXT Message Data From an Existing File

There are two options provided by the NEXT Serialization library for deserializing XML message data compatible
with the NEXT platform from a file.

> This section references the sample file found 
[here](https://github.com/diagraph-developer/NextSerialization/blob/main/NextSerializationExamples/SampleFiles/DiagraphReferenceResMarkData.next)

``` csharp
var inputFile = @"SampleFiles/DiagraphReferenceResMarkData.next";
```

### Use the static methods of the MessageSerialier class

``` csharp
var message = MessageSerializer.ReadMessageFile<NextMessage>(inputFile);
```

### Use the convience extension methods

``` csharp
var message = inputFile.ReadMessageFromFile();
```

## Serialize NEXT Message and Write to File

There are two options provided by the NEXT Serialization library for serializing message data from a
NextMessage object tree to an XML file compatible with the NEXT platform.

> This section references the sample file found 
[here](https://github.com/diagraph-developer/NextSerialization/blob/main/NextSerializationExamples/SampleFiles/DiagraphReferenceResMarkData.next)

``` csharp
var outputFile = @"SampleFiles/DiagraphReference_Serialized.next";
```

### Use the static methods of the MessageSerialier class

``` csharp
MessageSerializer.WriteMessageFile<NextMessage>(message, outputFile);
```

### Use the convience extension methods

``` csharp
message.WriteMessageToFile(outputFile);
```

## Deserialize In-Memory String data

NEXT Message data can also be deserialized from a `string` variable in memory.

``` csharp
var message = MessageSerializer.ReadMessageXml<NextMessage>(messageXmlString);
```