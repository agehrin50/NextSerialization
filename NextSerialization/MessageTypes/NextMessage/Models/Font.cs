namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// Describes the aspects of the typeface of a textual element.
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Font : IFontObject
{
    /// <summary>
    /// The name of the font to be rendered.
    /// </summary>
    [XmlAttribute]
    public string? Family { get; set; }

    /// <summary>
    /// The style to render the font (e.g. Italic, Bold, etc.).
    /// </summary>
    [XmlAttribute]
    public string? Style { get; set; }

    /// <summary>
    /// The overall horizontal dimention of the element.
    /// </summary>
    [XmlAttribute]
    public int Width { get; set; }

    /// <summary>
    /// The overall vertical dimention of the element.
    /// </summary>
    [XmlAttribute]
    public int Height { get; set; }
}
