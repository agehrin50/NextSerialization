namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// External data used to render elements of the message.
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Resource
{
    /// <summary>
    /// The name of the resource file.
    /// </summary>
    [XmlAttribute]
    public string? FileName { get; set; }
}
