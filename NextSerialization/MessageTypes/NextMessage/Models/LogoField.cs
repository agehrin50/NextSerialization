namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(TypeName = "LogoFieldObject")]
public class LogoField : FieldObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string FileName { get; set; }
}
