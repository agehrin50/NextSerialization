namespace NextSerialization.MessageTypes.NextMessage;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[XmlType(TypeName = nameof(DataSource))]
public class DataSource
{
    /// <summary>
    /// 
    /// </summary>
    [XmlArray("DisplayColumns")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[] DisplayColumns { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("DataColumns")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[] DataColumns { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlArray("ColumnValues")]
    [XmlArrayItem("Column", Type = typeof(Column), IsNullable = false)]
    public Column[] ColumnValues { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string Name { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string TableName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute()]
    public string DataConnection { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute("ID")]
    public string Id { get; set; }
}
