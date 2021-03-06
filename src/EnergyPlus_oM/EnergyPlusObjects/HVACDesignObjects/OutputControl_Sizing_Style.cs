using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description("Default style for the Sizing output files is comma -- this works well for importi" +
                 "ng into spreadsheet programs such as Excel(tm) but not so well for word processi" +
                 "ng programs -- there tab may be a better choice. Fixed puts spaces between the \"" +
                 "columns\"")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutputControl_Sizing_Style : BHoMObject
    {
        

        [JsonProperty(PropertyName="column_separator", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public OutputControl_Sizing_Style_ColumnSeparator ColumnSeparator { get; set; } = (OutputControl_Sizing_Style_ColumnSeparator)Enum.Parse(typeof(OutputControl_Sizing_Style_ColumnSeparator), "Comma");
    }
}