using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"This object sets up holidays/special days to be used during weather file run periods. (These are not used with SizingPeriod:* objects.) Depending on the value in the run period, days on the weather file may also be used. However, the weather file specification will take precedence over any specification shown here. (No error message on duplicate days or overlapping days).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriodControl_SpecialDays : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Dates can be several formats: <number>/<number>  (month/day) <number> <Month> <Month> <number> <Nth> <Weekday> in <Month) Last <WeekDay> in <Month> <Month> can be January, February, March, April, May, June, July, August, September, October, November, December Months can be the first 3 letters of the month <Weekday> can be Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday <Nth> can be 1 or 1st, 2 or 2nd, etc. up to 5(?)")]
        [JsonProperty(PropertyName="start_date", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartDate { get; set; } = "";
        

        [JsonProperty(PropertyName="duration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Duration { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Special Day Type selects the schedules appropriate for each day so labeled")]
        [JsonProperty(PropertyName="special_day_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public RunPeriodControl_SpecialDays_SpecialDayType SpecialDayType { get; set; } = (RunPeriodControl_SpecialDays_SpecialDayType)Enum.Parse(typeof(RunPeriodControl_SpecialDays_SpecialDayType), "Holiday");
    }
}