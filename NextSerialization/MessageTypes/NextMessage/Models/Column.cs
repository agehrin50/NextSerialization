namespace NextSerialization.MessageTypes.NextMessage;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
public class Column
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
    public string Value { get; set; }
}
