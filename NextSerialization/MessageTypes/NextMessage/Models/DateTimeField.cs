namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(TypeName = "DateTimeFieldObject")]
public class DateTimeField : TextField, IFontObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Days { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool DaysSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Weeks { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool WeeksSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Months { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool MonthsSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Years { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool YearsSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string Format { get; set; }
}
