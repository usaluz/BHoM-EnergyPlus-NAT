using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections
{
    [Description("Specifies the HVAC equipment connections for a zone. Node names are specified for" +
                 " the zone air node, air inlet nodes, air exhaust nodes, and the air return node." +
                 " A zone equipment list is referenced which lists all HVAC equipment connected to" +
                 " the zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_EquipmentConnections : BHoMObject
    {
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a ZoneHVAC:EquipmentList object.")]
        [JsonProperty(PropertyName="zone_conditioning_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneConditioningEquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_air_inlet_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneAirInletNodeOrNodelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_air_exhaust_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneAirExhaustNodeOrNodelistName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_return_air_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneReturnAirNodeOrNodelistName { get; set; } = "";
        

        [Description("This schedule is multiplied times the base return air flow rate. If this field is" +
                     " left blank, the schedule defaults to 1.0 at all times.")]
        [JsonProperty(PropertyName="zone_return_air_node_1_flow_rate_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneReturnAirNode1FlowRateFractionScheduleName { get; set; } = "";
        

        [Description(@"The optional basis node(s) used to calculate the base return air flow rate for the first return air node in this zone. The return air flow rate is the sum of the flow rates at the basis node(s) multiplied by the Zone Return Air Flow Rate Fraction Schedule. If this  field is blank, then the base return air flow rate is the total supply inlet flow rate to the zone less the total exhaust node flow rate from the zone.")]
        [JsonProperty(PropertyName="zone_return_air_node_1_flow_rate_basis_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneReturnAirNode1FlowRateBasisNodeOrNodelistName { get; set; } = "";
    }
}