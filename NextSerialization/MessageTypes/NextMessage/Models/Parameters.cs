namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

/// <summary>
/// Defines aspects of the barcode required to validate and render properly.
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
public class Parameters
{
    private decimal ratio;
    private bool isHumanReadable;
    private bool checksum;
    private bool caseSensitive;

    /// <summary>
    /// Used to prevent the direct printing pressure from being concentrated on the barcode and to keep the printing pressure even.
    /// </summary>
    [XmlElement(IsNullable = false)]
    public Bearer? Bearer { get; set; }

    /// <summary>
    /// Specifies the width of the narrowest element, whether it's a bar or space, in thousandths of an inch.
    /// </summary>
    [XmlAttribute]
    public int MilSize { get; set; }

    /// <summary>
    /// The quiet zone is the area that surrounds the barcode or 2D symbol that is free of all text, characters, graphics, marks, and blemishes.
    /// This blank space allows verifiers or readers to " understand" where the barcode begins and ends so the code can be read as intended.
    /// </summary>
    [XmlAttribute]
    public decimal QuietZone { get; set; }

    /// <summary>
    /// Indicates that the textual representation of the barcode data is also rendered.
    /// </summary>
    [XmlAttribute]
    public string IsHumanReadable
    {
        get => isHumanReadable.ToString();
        set => isHumanReadable = bool.Parse(value);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="IsHumanReadable"/> XML node when the value of <see cref="IsHumanReadable"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool IsHumanReadableSpecified { get; set; }

    /// <summary>
    /// The differenc of width of the thin and thick bars on an I2 of 5 barcode type.
    /// </summary>
    [XmlAttribute("Ratio")]
    public string FormattedRatio
    {
        get => ratio.ToString("F3");
        set => decimal.TryParse(value, out ratio);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="FormattedRatio"/> XML node when the value of <see cref="FormattedRatio"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool FormattedRatioSpecified { get; set; }

    /// <summary>
    /// The number located on the far right side of a bar code. The purpose of a check digit is to verify 
    /// that the information on the barcode has been entered correctly.
    /// </summary>
    [XmlAttribute]
    public string Checksum
    {
        get => checksum.ToString();
        set => checksum = bool.Parse(value);
    }

    /// <summary>
    /// Specifies the type of encoding for the barcode. (ex. 8-bit)
    /// </summary>
    [XmlAttribute]
    public string Encoding { get; set; }

    /// <summary>
    /// Tells the serializer to omit the <see cref="Encoding"/> XML node when the value of <see cref="Encoding"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool EncodingSpecified { get; set; }

    /// <summary>
    /// Indicates whether the barcode is case sensitive or not.
    /// </summary>
    [XmlAttribute]
    public string CaseSensitive
    {
        get => caseSensitive.ToString();
        set => caseSensitive = bool.Parse(value);
    }

    /// <summary>
    /// Tells the serializer to omit the <see cref="CaseSensitive"/> XML node when the value of <see cref="CaseSensitive"/> is 
    /// the default value or null.
    /// </summary>
    /// <remarks>
    /// This property is used internally by the serializer and should not be set programatically.
    /// </remarks>
    [XmlIgnore]
    public bool CaseSensitiveSpecified { get; set; }
}
