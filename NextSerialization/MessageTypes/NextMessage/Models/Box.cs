namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Defines the overall dimentions of the surfaces and message.
/// </summary>
/// <remarks>Data is not currently used.</remarks>
[Serializable]
[XmlType(AnonymousType = true)]
public class Box
{
    /// <summary>
    /// The width of the print surface.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// The length of the message.
    /// </summary>
    [XmlAttribute]
    public decimal Length { get; set; }

    /// <summary>
    /// The height of the print surface.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}
