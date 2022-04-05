namespace NextSerialization.MessageTypes.NextMessage;

using System;
using System.Xml.Serialization;

using NextSerialization.MessageTypes.NextMessage.Interfaces;

/// <summary>
/// Contains properties that are used to define a general content element on
/// a <see cref="NextMessage"/> file and serves as the base class for the all derived
/// fields.
/// <h2>Derived Fields</h2>
/// <list type="table">
/// <item><term><seealso cref="BarcodeField"/></term><description>Defines the barcode type and other rendering aspects needed to render and print a barcode element.</description></item>
/// <item><term><seealso cref="CountField"/></term><description>Defines the properties needed to render and print an incremental count element.</description></item>
/// <item><term><seealso cref="DateTimeField"/></term><description>Defines the format and style for rendering and printing a date or time element.</description></item>
/// <item><term><seealso cref="LineField"/></term><description>Defines the length, line weight, and orientation to render and print a line element.</description></item>
/// <item><term><seealso cref="LogoField"/></term><description>Defines the file name and dimentions required to render and print an image element.</description></item>
/// <item><term><seealso cref="RectangleField"/></term><description>Defines the length, width, line weight, and orientation to render and print a rectangular element.</description></item>
/// <item><term><seealso cref="TextField"/></term><description>Defines the font and other aspects required to render and print a text element.</description></item>
/// <item><term><seealso cref="VariableField"/></term><description>Defines the data source and other aspects to render and print a data bound element.</description></item>
/// </list>
/// </summary>
[Serializable]
[XmlType(AnonymousType = true)]
[XmlInclude(typeof(LogoField))]
[XmlInclude(typeof(LineField))]
[XmlInclude(typeof(CountField))]
[XmlInclude(typeof(DateTimeField))]
[XmlInclude(typeof(BarcodeField))]
[XmlInclude(typeof(RectangleField))]
[XmlInclude(typeof(TextField))]
[XmlInclude(typeof(VariableField))]
public abstract class FieldObject : IFieldObject
{
    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal X { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Y { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public virtual decimal Width { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public decimal Height { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public string LockAspectRatio { get; set; }

    /// <summary>
    /// 
    /// </summary>
    [XmlAttribute]
    public virtual string FNC1 { get; set; }
}
