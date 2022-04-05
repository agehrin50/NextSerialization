namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlRoot(ElementName = "ProductObject", Namespace = "", IsNullable = false)]
public class Product
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal GapBetweenPrint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string TaskType { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public int PrintCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string UsePrintCount { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string ContinuousPrint { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("DPI")]
    public int Dpi { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Margin", IsNullable = false)]
    public Margin Margin { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Box")]
    public Box Box { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Variables")]
    public Variables Variables { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlElement("Panel")]
    public Panel[] Panel { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("Resources")]
    [XmlArrayItem("Resource", IsNullable = false)]
    public Resource[] Resources { get; set; }
}
