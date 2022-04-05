namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(TypeName = "CountFieldObject")]
public class CountField : TextField
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int StartCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StartCountSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int StopCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool StopCountSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int Increment { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool IncrementSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int NumberOfDigits { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool NumberOfDigitsSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int PalletSize { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore]
    public bool PalletSizeSpecified { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string AlphaCount { get; set; }
}
