namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Parameters
{
    /// <summary>
    /// 
    /// </summary>
    [XmlElement(IsNullable = false)]
    public Bearer Bearer { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public int MilSize { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public decimal QuietZone { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string IsHumanReadable { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlIgnore()]
    public decimal Ratio { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("Ratio")]
    public string FormattedRatio
    {
        get => Ratio.ToString("F3");
        set
        {
            if (decimal.TryParse(value, out var ratio))
            {
                Ratio = ratio;
            }
        }
    }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string Checksum { get; set; }
}
