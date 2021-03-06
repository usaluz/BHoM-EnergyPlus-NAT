using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This setpoint manager sets both the supply air temperature and the supply air flo" +
                 "w rate.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_WarmestTemperatureFlow : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_WarmestTemperatureFlow_ControlVariable ControlVariable { get; set; } = (SetpointManager_WarmestTemperatureFlow_ControlVariable)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_ControlVariable), "Temperature");
        

        [Description("Enter the name of an AirLoopHVAC object.")]
        [JsonProperty(PropertyName="hvac_air_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HvacAirLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumSetpointTemperature { get; set; } = Double.Parse("12", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumSetpointTemperature { get; set; } = Double.Parse("18", CultureInfo.InvariantCulture);
        

        [Description(@"For TemperatureFirst the manager tries to find the highest setpoint temperature that will satisfy all the zone cooling loads at minimum supply air flow rate. If this setpoint temperature is less than the minimum, the setpoint temperature is set to the minimum, and the supply air flow rate is increased to meet the loads. For FlowFirst the manager tries to find the lowest supply air flow rate that will satisfy all the zone cooling loads at the maximum setpoint temperature. If this flow is greater than the maximum, the flow is set to the maximum and the setpoint temperature is reduced to satisfy the cooling loads.")]
        [JsonProperty(PropertyName="strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_WarmestTemperatureFlow_Strategy Strategy { get; set; } = (SetpointManager_WarmestTemperatureFlow_Strategy)Enum.Parse(typeof(SetpointManager_WarmestTemperatureFlow_Strategy), "TemperatureFirst");
        

        [Description("Node(s) at which the temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Fraction of the maximum supply air flow rate. Used to define the minimum supply f" +
                     "low for the TemperatureFirst strategy.")]
        [JsonProperty(PropertyName="minimum_turndown_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTurndownRatio { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
    }
}