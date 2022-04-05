namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Font : IFontObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string Family { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string Style { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Width { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Height { get; set; }
}
