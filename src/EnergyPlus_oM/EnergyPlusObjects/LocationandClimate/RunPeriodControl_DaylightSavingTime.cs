using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.LocationandClimate
{
    [Description(@"This object sets up the daylight saving time period for any RunPeriod. Ignores any daylight saving time period on the weather file and uses this definition. These are not used with SizingPeriod:DesignDay objects. Use with SizingPeriod:WeatherFileDays object can be controlled in that object.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class RunPeriodControl_DaylightSavingTime : BHoMObject
    {
        

        [JsonProperty(PropertyName="start_date", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StartDate { get; set; } = "";
        

        [Description(@"Dates can be several formats: <number>/<number>  (month/day) <number> <Month> <Month> <number> <Nth> <Weekday> in <Month) Last <WeekDay> in <Month> <Month> can be January, February, March, April, May, June, July, August, September, October, November, December Months can be the first 3 letters of the month <Weekday> can be Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday <Nth> can be 1 or 1st, 2 or 2nd, etc. up to 5(?)")]
        [JsonProperty(PropertyName="end_date", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EndDate { get; set; } = "";
    }
}