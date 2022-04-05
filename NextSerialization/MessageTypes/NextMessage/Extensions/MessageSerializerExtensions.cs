namespace NextSerialization.MessageTypes.NextMessage.Extensions;

using NextSerialization.MessageTypes.NextMessage.Models;
using NextSerialization.MessageTypes.NextMessage.Serialization;

/// <summary>
/// Contains convenience methods for serializing/deserializing message data to and from file.
/// </summary>
public static class MessageSerializerExtensions
{
    /// <summary>
    /// Writes the <paramref name="message"/> data to <paramref name="outputFileName"/> as XML.
    /// </summary>
    /// <param name="message">The message data to be written.</param>
    /// <param name="outputFileName">The full or relative path and filename of the file to be written.</param>
    public static void WriteMessageToFile(this NextMessage message, string outputFileName) =>
         new MessageSerializer().WriteMessageFile<Product>(message.Product, outputFileName);

    /// <summary>
    /// Reads the XML from <paramref name="inputFile"/> as a <see cref="NextMessage"/>.
    /// </summary>
    /// <param name="inputFile">The full or relative path and filename to read.</param>
    /// <returns>A <see cref="NextMessage"/> hydrated with the XML data from <paramref name="inputFile"/>.</returns>
    public static NextMessage? ReadMessageFromFile(this string inputFile) => new()
    {
        Product = new MessageSerializer().ReadMessageFile<Product>(inputFile)
            ?? throw new InvalidOperationException($"Unable to read message data from {inputFile}")
    };
}
