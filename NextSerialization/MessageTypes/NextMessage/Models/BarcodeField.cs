namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(TypeName = "BarcodeFieldObject")]
public class BarcodeField : FieldObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string Type { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Parameters", IsNullable = false)]
    public Parameters Parameters { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Font", IsNullable = false)]
    public Font Font { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("FieldObject")]
    public FieldObject[] FieldObject { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool FieldObjectSpecified { get; set; }
}
