namespace NextSerialization.MessageTypes.NextMessage;

using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
public class LineThickness
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Width { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }
}