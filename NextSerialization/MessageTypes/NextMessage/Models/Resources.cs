namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Resources
{
    /// <summary>
    /// 
    /// </summary>
    public Resource[] Resource { get; set; }
}
