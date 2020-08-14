// NOTE: Generated code may require at least .NET Framework 4.5 or .NET Core/Standard 2.0.
/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class root
{

    private rootLocation locationField;

    private rootCurrent currentField;

    private rootForecastday[] forecastField;

    private object alertField;

    private object city;

    /// <remarks/>
    public rootLocation location
    {
        get
        {
            return this.locationField;
        }
        set
        {
            this.locationField = value;
        }
    }

    /// <remarks/>
    public rootCurrent current
    {
        get
        {
            return this.currentField;
        }
        set
        {
            this.currentField = value;
        }
    }

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("forecastday", IsNullable = false)]
    public rootForecastday[] forecast
    {
        get
        {
            return this.forecastField;
        }
        set
        {
            this.forecastField = value;
        }
    }

    /// <remarks/>
    public object alert
    {
        get
        {
            return this.alertField;
        }
        set
        {
            this.alertField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootLocation
{

    private string nameField;

    private string regionField;

    private string countryField;

    private decimal latField;

    private decimal lonField;

    private string tz_idField;

    private uint localtime_epochField;

    private string localtimeField;

    /// <remarks/>
    public string name
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
    public string region
    {
        get
        {
            return this.regionField;
        }
        set
        {
            this.regionField = value;
        }
    }

    /// <remarks/>
    public string country
    {
        get
        {
            return this.countryField;
        }
        set
        {
            this.countryField = value;
        }
    }

    /// <remarks/>
    public decimal lat
    {
        get
        {
            return this.latField;
        }
        set
        {
            this.latField = value;
        }
    }

    /// <remarks/>
    public decimal lon
    {
        get
        {
            return this.lonField;
        }
        set
        {
            this.lonField = value;
        }
    }

    /// <remarks/>
    public string tz_id
    {
        get
        {
            return this.tz_idField;
        }
        set
        {
            this.tz_idField = value;
        }
    }

    /// <remarks/>
    public uint localtime_epoch
    {
        get
        {
            return this.localtime_epochField;
        }
        set
        {
            this.localtime_epochField = value;
        }
    }

    /// <remarks/>
    public string localtime
    {
        get
        {
            return this.localtimeField;
        }
        set
        {
            this.localtimeField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootCurrent
{

    private byte temp_cField;

    private rootCurrentCondition conditionField;

    private byte uvField;

    /// <remarks/>
    public byte temp_c
    {
        get
        {
            return this.temp_cField;
        }
        set
        {
            this.temp_cField = value;
        }
    }

    /// <remarks/>
    public rootCurrentCondition condition
    {
        get
        {
            return this.conditionField;
        }
        set
        {
            this.conditionField = value;
        }
    }

    /// <remarks/>
    public byte uv
    {
        get
        {
            return this.uvField;
        }
        set
        {
            this.uvField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootCurrentCondition
{

    private string textField;

    private string iconField;

    /// <remarks/>
    public string text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    public string icon
    {
        get
        {
            return this.iconField;
        }
        set
        {
            this.iconField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootForecastday
{

    private System.DateTime dateField;

    private uint date_epochField;

    private rootForecastdayDay dayField;

    private object astroField;

    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute(DataType = "date")]
    public System.DateTime date
    {
        get
        {
            return this.dateField;
        }
        set
        {
            this.dateField = value;
        }
    }

    /// <remarks/>
    public uint date_epoch
    {
        get
        {
            return this.date_epochField;
        }
        set
        {
            this.date_epochField = value;
        }
    }

    /// <remarks/>
    public rootForecastdayDay day
    {
        get
        {
            return this.dayField;
        }
        set
        {
            this.dayField = value;
        }
    }

    /// <remarks/>
    public object astro
    {
        get
        {
            return this.astroField;
        }
        set
        {
            this.astroField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootForecastdayDay
{

    private decimal maxtemp_cField;

    private decimal mintemp_cField;

    private rootForecastdayDayCondition conditionField;

    /// <remarks/>
    public decimal maxtemp_c
    {
        get
        {
            return this.maxtemp_cField;
        }
        set
        {
            this.maxtemp_cField = value;
        }
    }

    /// <remarks/>
    public decimal mintemp_c
    {
        get
        {
            return this.mintemp_cField;
        }
        set
        {
            this.mintemp_cField = value;
        }
    }

    /// <remarks/>
    public rootForecastdayDayCondition condition
    {
        get
        {
            return this.conditionField;
        }
        set
        {
            this.conditionField = value;
        }
    }
}

/// <remarks/>
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class rootForecastdayDayCondition
{

    private string textField;

    private string iconField;

    /// <remarks/>
    public string text
    {
        get
        {
            return this.textField;
        }
        set
        {
            this.textField = value;
        }
    }

    /// <remarks/>
    public string icon
    {
        get
        {
            return this.iconField;
        }
        set
        {
            this.iconField = value;
        }
    }
}
