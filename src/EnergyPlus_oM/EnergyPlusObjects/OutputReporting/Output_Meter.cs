using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description(@"Each Output:Meter command picks meters to be put onto the standard output file (.eso) and meter file (.mtr). Not all meters are reported in every simulation. A list of meters that can be reported are available after a run on the meter dictionary file (.mdd) if the Output:VariableDictionary has been requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Meter : BHoMObject
    {
        

        [Description("Form is EnergyUseType:..., e.g. Electricity:* for all Electricity meters or EndUs" +
                     "e:..., e.g. GeneralLights:* for all General Lights Output:Meter puts results on " +
                     "both the eplusout.mtr and eplusout.eso files")]
        [JsonProperty(PropertyName="key_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string KeyName { get; set; } = "";
        

        [Description("Timestep refers to the zone Timestep/Number of Timesteps in hour value RunPeriod " +
                     "and Environment are the same")]
        [JsonProperty(PropertyName="reporting_frequency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Output_Meter_ReportingFrequency ReportingFrequency { get; set; } = (Output_Meter_ReportingFrequency)Enum.Parse(typeof(Output_Meter_ReportingFrequency), "Hourly");
    }
}