using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirDistribution
{
    [Description("Outdoor air mixer. Node names cannot be duplicated within a single OutdoorAir:Mix" +
                 "er object or across all outdoor air mixers.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class OutdoorAir_Mixer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of Mixed Air Node")]
        [JsonProperty(PropertyName="mixed_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Name of Outdoor Air Stream Node")]
        [JsonProperty(PropertyName="outdoor_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Relief Air Stream Node")]
        [JsonProperty(PropertyName="relief_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReliefAirStreamNodeName { get; set; } = "";
        

        [Description("Name of Return Air Stream Node")]
        [JsonProperty(PropertyName="return_air_stream_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirStreamNodeName { get; set; } = "";
    }
}