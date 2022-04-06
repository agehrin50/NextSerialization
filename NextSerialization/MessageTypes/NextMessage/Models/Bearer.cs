namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Defines the bounding box of the rendered barcode element.
/// </summary>
[Serializable]
public class Bearer
{
    /// <summary>
    /// The width of the vertical lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// The with of the horizontal lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}
