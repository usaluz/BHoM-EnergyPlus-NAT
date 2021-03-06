using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description("This object is used to override internal sky temperature calculations.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WeatherProperty_SkyTemperature : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The field indicates that the sky temperature will be imported from external sched" +
                     "ules or calculated by alternative methods other than default.")]
        [JsonProperty(PropertyName="calculation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WeatherProperty_SkyTemperature_CalculationType CalculationType { get; set; } = (WeatherProperty_SkyTemperature_CalculationType)Enum.Parse(typeof(WeatherProperty_SkyTemperature_CalculationType), "ClarkAllen");
        

        [Description(@"if name matches a SizingPeriod:DesignDay, put in a day schedule of this name if name is for a SizingPeriod:WeatherFileDays, SizingPeriod:WeatherFileConditionType or RunPeriod, put in a full year schedule that covers the appropriate days. Required if Calculation Type is ScheduleValue, DifferenceScheduleDryBulbValue or DifferenceScheduleDewPointValue.")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description(@"If yes or blank, use Horizontal IR values from weather file when present, otherwise use the specified sky model. If no, always use the specified sky model and ignore the horizontal IR values from the weather file. For Calculation Type = ScheduleValue, DifferenceScheduleDryBulbValue or DifferenceScheduleDewPointValue, this field is ignored and the scheduled values are used.")]
        [JsonProperty(PropertyName="use_weather_file_horizontal_ir", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes UseWeatherFileHorizontalIr { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
    }
}