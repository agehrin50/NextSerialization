namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// A textual element whos output is sourced from external data.
/// </summary>
[Serializable]
[XmlType(TypeName = "VarFieldObject")]
public class VariableField : TextField
{
    /// <summary>
    /// The type of data source (e.g. Database)
    /// </summary>
    [XmlAttribute]
    public string? Source { get; set; }

    /// <summary>
    /// Identifies the name of the <code>DataSetObject</code> of <see cref="Variables.DataSources"/>.
    /// </summary>
    [XmlAttribute]
    public string? DataSetName { get; set; }

    /// <summary>
    /// Identifies the <see cref="Column.Name"/> of the <code>DataColumns</code> XML node.
    /// </summary>
    [XmlAttribute]
    public string? DataColumnName { get; set; }

    /// <summary>
    /// The value from the data to use when displaying the <see cref="VariableField"/> on the drawing surface.
    /// </summary>
    [XmlAttribute]
    public string? DefaultPreview { get; set; }

    /// <summary>
    /// The text to display to the user in a variable prompt.
    /// </summary>
    [XmlAttribute]
    public string PromptText { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="PromptText"/> XML node when the value of <see cref="PromptText"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool PromptTextSpecified { get; set; }

    /// <summary>
    /// The length of the data.
    /// </summary>
    [XmlAttribute]
    public int Length { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Length"/> XML node when the value of <see cref="Length"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool LengthSpecified { get; set; }
}
