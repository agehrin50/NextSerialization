namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// A horizontal or vertical line element.
/// </summary>
[Serializable]
[XmlType(TypeName = "LineFieldObject")]
[XmlInclude(typeof(RectangleField))]
[XmlInclude(typeof(LogoField))]
public class LineField : FieldObject
{
    /// <summary>
    /// Indicates whether the shape is oriented horizontally or vertically.
    /// </summary>
    [XmlAttribute]
    public string? Orientation { get; set; }

    /// <summary>
    /// The thickness of the stroke.
    /// </summary>
    [XmlElement("LineThickness")]
    public LineThickness? LineThickness { get; set; }
}
