using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object defines the connection between two nodes and a component used in the " +
                 "combination of RoomAir and AirflowNetwork model.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_IntraZone_Linkage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty(PropertyName="node_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Node1Name { get; set; } = "";
        

        [Description("Enter the name of zone or AirflowNetwork Node.")]
        [JsonProperty(PropertyName="node_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Node2Name { get; set; } = "";
        

        [Description(@"Enter the name of an AirflowNetwork component. A component is one of the following AirflowNetwork:Multizone:Component objects: AirflowNetwork:MultiZone:Surface:Crack, AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea, If the next field is specified, this field can be either blank or ignored.")]
        [JsonProperty(PropertyName="component_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ComponentName { get; set; } = "";
        

        [Description("Only used when one of two nodes defined above are not located in the same zone, a" +
                     "nd the input of the Component Name field in this object is ignored")]
        [JsonProperty(PropertyName="airflownetwork_multizone_surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirflownetworkMultizoneSurfaceName { get; set; } = "";
    }
}