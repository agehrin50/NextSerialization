namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(TypeName = "Head")]
public class PrintHead
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FieldObject")]
    public FieldObject[] FieldObjects { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("UID")]
    public int Uid { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public int Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore()]
    public bool TypeSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public decimal Offset { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string Enabled { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("DPI")]
    public int Dpi { get; set; }
}
