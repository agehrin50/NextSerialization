namespace NextSerialization.MessageTypes.Next.Enumerations;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
public enum PrintResolutions
{
    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "150")]
    Low,

    /// <summary>
    /// 
    /// </summary>
    [XmlEnum(Name = "300")]
    High
}
