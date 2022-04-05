namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// 
/// </summary>
[Serializable]
[XmlType(TypeName = "VarFieldObject")]
public class VariableField : TextField
{
    /// <summary>
    /// 
    /// </summary>
    public string Source { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string DataSetName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string DataColumnName { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public string DefaultPreview { get; set; }
}
