namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Resource
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string FileName { get; set; }
}
