namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(TypeName = "LineFieldObject")]
[XmlInclude(typeof(RectangleField))]
[XmlInclude(typeof(LogoField))]
public class LineField : FieldObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string? Orientation { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("LineThickness")]
    public LineThickness? LineThickness { get; set; }
}
