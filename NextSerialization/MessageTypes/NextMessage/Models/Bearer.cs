namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Defines the thickness of the lines that create a bounding box around the rendered barcode element.
/// </summary>
[Serializable]
public class Bearer
{
    /// <summary>
    /// The width, in inches, of the vertical lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// The width, in inches, of the horizontal lines of the bounding box.
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}
