namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Represents a physical print head and defines the data that will be rendered and printed by that print head.
/// </summary>
[Serializable]
[XmlType(TypeName = "Head")]
public class PrintHead
{
    private bool enabled;

    /// <summary>
    /// The collection of elements that are rendered on the message.
    /// </summary>
    [XmlElement("FieldObject")]
    public FieldObject[] FieldObjects { get; set; }

    /// <summary>
    /// Maps the message segment to the print head.
    /// </summary>
    [XmlAttribute("UID")]
    public int Uid { get; set; }

    /// <summary>
    /// The name of the print head.
    /// </summary>
    [XmlAttribute]
    public string Name { get; set; }

    /// <summary>
    /// A value indicating the type of print head to use to print the message.
    /// </summary>
    /// <remarks>
    /// Valid Print Head Types
    /// <list type="table">
    /// <item><term>384</term><description>MARK 2</description></item>
    /// <item><term>768</term><description>MARK 4</description></item>
    /// </list>
    /// </remarks>
    [XmlAttribute]
    public int Type { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Type"/> XML node when the value of <see cref="Type"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool TypeSpecified { get; set; }

    /// <summary>
    /// The physical distance that the print head is from the trigger point.
    /// </summary>
    [XmlAttribute]
    public decimal Offset { get; set; }

    /// <summary>
    /// Indicates whether the print head is used to print the message.
    /// </summary>
    [XmlAttribute]
    public string Enabled
    {
        get => enabled.ToString();
        set => enabled = bool.Parse(value);
    }

    /// <summary>
    /// The horizontal resolution of the print head.
    /// </summary>
    [XmlAttribute("DPI")]
    public int Dpi { get; set; }
}
