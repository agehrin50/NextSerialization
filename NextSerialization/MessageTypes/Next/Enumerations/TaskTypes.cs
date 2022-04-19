namespace NextSerialization.MessageTypes.Next.Enumerations;
using System.Xml.Serialization;

/// <summary>
/// Enumerated print technologies available.
/// </summary>
public enum TaskTypes
{
    /// <summary>
    /// Indicates that the Trident print engine technology is used.
    /// </summary>
    [XmlEnum(Name = "HighResTask")]
    HighResTask
}
