
using NextSerialization.MessageTypes.NextMessage.Extensions;
using NextSerialization.MessageTypes.NextMessage.Serialization;

try
{
    var inputFile = @"Resources/DiagraphReferenceResMarkData.next";
    var outputFile = @"Resources/DiagraphReference_Serialized.next";
    File.Delete(outputFile);

    //var xdoc = XDocument.Load(inputFile);


    var messageSerializer = new MessageSerializer();

    Console.WriteLine($"Reading message data from {inputFile}");
    var message = inputFile.ReadMessageFromFile();

    if (message is null)
    {
        throw new InvalidOperationException("Unable to deserialize message data.");
    }

    Console.WriteLine("Message successfully read.");
    Console.WriteLine($"Writing message data to {outputFile}");

    message.WriteMessageToFile(outputFile);

    Console.WriteLine("Message file successfully written.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();