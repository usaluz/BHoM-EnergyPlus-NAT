using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SimulationParameters
{
    [Description("Determines which contaminant concentration will be simulates.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneAirContaminantBalance : BHoMObject
    {
        

        [Description("If Yes, CO2 simulation will be performed.")]
        [JsonProperty(PropertyName="carbon_dioxide_concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes CarbonDioxideConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Schedule values should be in parts per million (ppm)")]
        [JsonProperty(PropertyName="outdoor_carbon_dioxide_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorCarbonDioxideScheduleName { get; set; } = "";
        

        [Description("If Yes, generic contaminant simulation will be performed.")]
        [JsonProperty(PropertyName="generic_contaminant_concentration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes GenericContaminantConcentration { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Schedule values should be generic contaminant concentration in parts per million " +
                     "(ppm)")]
        [JsonProperty(PropertyName="outdoor_generic_contaminant_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorGenericContaminantScheduleName { get; set; } = "";
    }
}