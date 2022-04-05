namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
public class Panel
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Head")]
    public PrintHead[] PrintHead { get; set; }
}
