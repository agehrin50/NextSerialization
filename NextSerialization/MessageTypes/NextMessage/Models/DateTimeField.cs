namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// Represents a textual element consisting of a formatted date and/or timestamp including configured
/// day/week/month/year offsets.
/// </summary>
[Serializable]
[XmlType(TypeName = "DateTimeFieldObject")]
public class DateTimeField : TextField, IFontObject
{
    /// <summary>
    /// The number of days to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Days { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Days"/> XML node when the value of <see cref="Days"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool DaysSpecified { get; set; }

    /// <summary>
    /// The number of weeks to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Weeks { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Weeks"/> XML node when the value of <see cref="Weeks"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool WeeksSpecified { get; set; }

    /// <summary>
    /// The number of months to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Months { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Months"/> XML node when the value of <see cref="Months"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool MonthsSpecified { get; set; }

    /// <summary>
    /// The number of years to offset from the current date.
    /// </summary>
    [XmlAttribute]
    public int Years { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Years"/> XML node when the value of <see cref="Years"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool YearsSpecified { get; set; }

    /// <summary>
    /// A string that describes the ouptut format.
    /// </summary>
    [XmlAttribute]
    public string? Format { get; set; }
}
