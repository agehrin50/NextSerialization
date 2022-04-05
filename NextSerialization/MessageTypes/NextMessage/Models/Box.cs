namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Box
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Length { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}
