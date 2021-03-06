using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("This is used to Automatically report the facility meters and turn on the Environm" +
                 "ental Impact Report calculations for all of the Environmental Factors.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_EnvironmentalImpactFactors : BHoMObject
    {
        

        [Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
                     "and Environment are the same. Detailed is not a valid choice.")]
        [JsonProperty(PropertyName="reporting_frequency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_EnvironmentalImpactFactors_ReportingFrequency ReportingFrequency { get; set; } = (Output_EnvironmentalImpactFactors_ReportingFrequency)Enum.Parse(typeof(Output_EnvironmentalImpactFactors_ReportingFrequency), "Annual");
    }
}