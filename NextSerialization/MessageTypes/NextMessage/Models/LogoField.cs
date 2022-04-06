namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// An image element.
/// </summary>
[Serializable()]
[XmlType(TypeName = "LogoFieldObject")]
public class LogoField : FieldObject
{
    /// <summary>
    /// The name of the image file.
    /// </summary>
    [XmlAttribute]
    public string FileName { get; set; }
}
