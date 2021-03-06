using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneAirflow
{
    [Description(@"Provide a combined zone outdoor air flow by including interactions between mechanical ventilation, infiltration and duct leakage. This object will combine outdoor flows from all ZoneInfiltration and ZoneVentilation objects in the same zone. Balanced flows will be summed, while unbalanced flows will be added in quadrature.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneAirBalance_OutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("None: Only perform simple calculations without using a combined zone outdoor air." +
                     " Quadrature: A combined outdoor air is used in the quadrature sum.")]
        [JsonProperty(PropertyName="air_balance_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneAirBalance_OutdoorAir_AirBalanceMethod AirBalanceMethod { get; set; } = (ZoneAirBalance_OutdoorAir_AirBalanceMethod)Enum.Parse(typeof(ZoneAirBalance_OutdoorAir_AirBalanceMethod), "Quadrature");
        

        [JsonProperty(PropertyName="induced_outdoor_air_due_to_unbalanced_duct_leakage", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> InducedOutdoorAirDueToUnbalancedDuctLeakage { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This schedule contains the fraction values applied to the Induced Outdoor Air giv" +
                     "en in the previous input field (0.0 - 1.0).")]
        [JsonProperty(PropertyName="induced_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InducedOutdoorAirScheduleName { get; set; } = "";
    }
}