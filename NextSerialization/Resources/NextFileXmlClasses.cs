
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class ProductObject
{

    public object marginField { get; set; }
    
    public ProductObjectBox boxField { get; set; }
    
    public ProductObjectVariables variablesField { get; set; }

    [System.Xml.Serialization.XmlElementAttribute("Panel")]
   
    public ProductObjectPanel[] panelField { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string nameField { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal gapBetweenPrintField { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string taskTypeField { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte printCountField { get; set; }

    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte dPIField { get; set; }



    /// <remarks/>
    public ProductObjectBox Box
    {
        get
        {
            return this.boxField;
        }
        set
        {
            this.boxField = value;
        }
    }

    /// <remarks/>
    public ProductObjectVariables Variables
    {
        get
        {
            return this.variablesField;
        }
        set
        {
            this.variablesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("Panel")]
    public ProductObjectPanel[] Panel
    {
        get
        {
            return this.panelField;
        }
        set
        {
            this.panelField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal GapBetweenPrint
    {
        get
        {
            return this.gapBetweenPrintField;
        }
        set
        {
            this.gapBetweenPrintField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TaskType
    {
        get
        {
            return this.taskTypeField;
        }
        set
        {
            this.taskTypeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte PrintCount
    {
        get
        {
            return this.printCountField;
        }
        set
        {
            this.printCountField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte DPI
    {
        get
        {
            return this.dPIField;
        }
        set
        {
            this.dPIField = value;
        }
    }

    public object MarginField { get; set; }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectBox
{

    private decimal widthField;

    private decimal lengthField;

    private decimal heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Length
    {
        get
        {
            return this.lengthField;
        }
        set
        {
            this.lengthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariables
{

    private ProductObjectVariablesDataSet dataSetField;

    /// <remarks/>
    public ProductObjectVariablesDataSet DataSet
    {
        get
        {
            return this.dataSetField;
        }
        set
        {
            this.dataSetField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariablesDataSet
{

    private ProductObjectVariablesDataSetDataSetObject dataSetObjectField;

    /// <remarks/>
    public ProductObjectVariablesDataSetDataSetObject DataSetObject
    {
        get
        {
            return this.dataSetObjectField;
        }
        set
        {
            this.dataSetObjectField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariablesDataSetDataSetObject
{

    private ProductObjectVariablesDataSetDataSetObjectColumn[] displayColumnsField;

    private ProductObjectVariablesDataSetDataSetObjectColumn1[] dataColumnsField;

    private ProductObjectVariablesDataSetDataSetObjectColumn2[] columnValuesField;

    private string nameField;

    private string tableNameField;

    private string dataConnectionField;

    private string idField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable = false)]
    public ProductObjectVariablesDataSetDataSetObjectColumn[] DisplayColumns
    {
        get
        {
            return this.displayColumnsField;
        }
        set
        {
            this.displayColumnsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable = false)]
    public ProductObjectVariablesDataSetDataSetObjectColumn1[] DataColumns
    {
        get
        {
            return this.dataColumnsField;
        }
        set
        {
            this.dataColumnsField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("Column", IsNullable = false)]
    public ProductObjectVariablesDataSetDataSetObjectColumn2[] ColumnValues
    {
        get
        {
            return this.columnValuesField;
        }
        set
        {
            this.columnValuesField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string TableName
    {
        get
        {
            return this.tableNameField;
        }
        set
        {
            this.tableNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataConnection
    {
        get
        {
            return this.dataConnectionField;
        }
        set
        {
            this.dataConnectionField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string ID
    {
        get
        {
            return this.idField;
        }
        set
        {
            this.idField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariablesDataSetDataSetObjectColumn
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariablesDataSetDataSetObjectColumn1
{

    private string nameField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectVariablesDataSetDataSetObjectColumn2
{

    private string nameField;

    private string valueField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Value
    {
        get
        {
            return this.valueField;
        }
        set
        {
            this.valueField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanel
{

    private ProductObjectPanelHead headField;

    private string nameField;

    /// <remarks/>
    public ProductObjectPanelHead Head
    {
        get
        {
            return this.headField;
        }
        set
        {
            this.headField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHead
{

    private ProductObjectPanelHeadFieldObject[] fieldObjectField;

    private byte uIDField;

    private string nameField;

    private ushort typeField;

    private decimal offsetField;

    private string enabledField;

    private byte dPIField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("FieldObject")]
    public ProductObjectPanelHeadFieldObject[] FieldObject
    {
        get
        {
            return this.fieldObjectField;
        }
        set
        {
            this.fieldObjectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte UID
    {
        get
        {
            return this.uIDField;
        }
        set
        {
            this.uIDField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public ushort Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Offset
    {
        get
        {
            return this.offsetField;
        }
        set
        {
            this.offsetField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Enabled
    {
        get
        {
            return this.enabledField;
        }
        set
        {
            this.enabledField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte DPI
    {
        get
        {
            return this.dPIField;
        }
        set
        {
            this.dPIField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHeadFieldObject
{

    private ProductObjectPanelHeadFieldObjectParameters parametersField;

    private ProductObjectPanelHeadFieldObjectFont fontField;

    private ProductObjectPanelHeadFieldObjectFieldObject fieldObjectField;

    private decimal xField;

    private decimal yField;

    private string lockAspectRatioField;

    private string dataField;

    private string familyField;

    private string styleField;

    private byte widthField;

    private bool widthFieldSpecified;

    private decimal heightField;

    private string sourceField;

    private string dataSetNameField;

    private string dataColumnNameField;

    private string defaultPreviewField;

    private string typeField;

    /// <remarks/>
    public ProductObjectPanelHeadFieldObjectParameters Parameters
    {
        get
        {
            return this.parametersField;
        }
        set
        {
            this.parametersField = value;
        }
    }

    /// <remarks/>
    public ProductObjectPanelHeadFieldObjectFont Font
    {
        get
        {
            return this.fontField;
        }
        set
        {
            this.fontField = value;
        }
    }

    /// <remarks/>
    public ProductObjectPanelHeadFieldObjectFieldObject FieldObject
    {
        get
        {
            return this.fieldObjectField;
        }
        set
        {
            this.fieldObjectField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal X
    {
        get
        {
            return this.xField;
        }
        set
        {
            this.xField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Y
    {
        get
        {
            return this.yField;
        }
        set
        {
            this.yField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string LockAspectRatio
    {
        get
        {
            return this.lockAspectRatioField;
        }
        set
        {
            this.lockAspectRatioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Family
    {
        get
        {
            return this.familyField;
        }
        set
        {
            this.familyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public bool WidthSpecified
    {
        get
        {
            return this.widthFieldSpecified;
        }
        set
        {
            this.widthFieldSpecified = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Source
    {
        get
        {
            return this.sourceField;
        }
        set
        {
            this.sourceField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataSetName
    {
        get
        {
            return this.dataSetNameField;
        }
        set
        {
            this.dataSetNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DataColumnName
    {
        get
        {
            return this.dataColumnNameField;
        }
        set
        {
            this.dataColumnNameField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string DefaultPreview
    {
        get
        {
            return this.defaultPreviewField;
        }
        set
        {
            this.defaultPreviewField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Type
    {
        get
        {
            return this.typeField;
        }
        set
        {
            this.typeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHeadFieldObjectParameters
{

    private ProductObjectPanelHeadFieldObjectParametersBearer bearerField;

    private byte milSizeField;

    private decimal quietZoneField;

    private string isHumanReadableField;

    private decimal ratioField;

    private string checksumField;

    /// <remarks/>
    public ProductObjectPanelHeadFieldObjectParametersBearer Bearer
    {
        get
        {
            return this.bearerField;
        }
        set
        {
            this.bearerField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte MilSize
    {
        get
        {
            return this.milSizeField;
        }
        set
        {
            this.milSizeField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal QuietZone
    {
        get
        {
            return this.quietZoneField;
        }
        set
        {
            this.quietZoneField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string IsHumanReadable
    {
        get
        {
            return this.isHumanReadableField;
        }
        set
        {
            this.isHumanReadableField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Ratio
    {
        get
        {
            return this.ratioField;
        }
        set
        {
            this.ratioField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Checksum
    {
        get
        {
            return this.checksumField;
        }
        set
        {
            this.checksumField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHeadFieldObjectParametersBearer
{

    private decimal widthField;

    private decimal heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public decimal Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHeadFieldObjectFont
{

    private string familyField;

    private string styleField;

    private byte widthField;

    private byte heightField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Family
    {
        get
        {
            return this.familyField;
        }
        set
        {
            this.familyField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string Style
    {
        get
        {
            return this.styleField;
        }
        set
        {
            this.styleField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Width
    {
        get
        {
            return this.widthField;
        }
        set
        {
            this.widthField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Height
    {
        get
        {
            return this.heightField;
        }
        set
        {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class ProductObjectPanelHeadFieldObjectFieldObject
{

    private byte dataField;

    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public byte Data
    {
        get
        {
            return this.dataField;
        }
        set
        {
            this.dataField = value;
        }
    }
}

