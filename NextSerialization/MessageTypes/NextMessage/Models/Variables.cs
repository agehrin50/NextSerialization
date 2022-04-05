namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable()]
[XmlType(AnonymousType = true)]
public class Variables
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("DataSet")]
    [XmlArrayItem("DataSetObject", IsNullable = false)]
    public DataSource[] DataSources { get; set; }
}
