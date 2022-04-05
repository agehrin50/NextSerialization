namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(TypeName = "TextFieldObject")]
public class TextField : FieldObject, IFontObject
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
    public string Data { get; set; }
}
