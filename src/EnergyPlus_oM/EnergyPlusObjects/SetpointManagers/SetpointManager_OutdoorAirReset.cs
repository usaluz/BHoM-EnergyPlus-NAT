using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SetpointManagers
{
    [Description("This Setpoint Manager is used to place a setpoint temperature on system node acco" +
                 "rding to the outdoor air temperature using a reset rule. The outdoor air tempera" +
                 "ture is obtained from the weather information during the simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SetpointManager_OutdoorAirReset : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="control_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SetpointManager_OutdoorAirReset_ControlVariable ControlVariable { get; set; } = (SetpointManager_OutdoorAirReset_ControlVariable)Enum.Parse(typeof(SetpointManager_OutdoorAirReset_ControlVariable), "Temperature");
        

        [JsonProperty(PropertyName="setpoint_at_outdoor_low_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SetpointAtOutdoorLowTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="outdoor_low_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorLowTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="setpoint_at_outdoor_high_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SetpointAtOutdoorHighTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="outdoor_high_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorHighTemperature { get; set; } = null;
        

        [Description("Node(s) at which temperature will be set")]
        [JsonProperty(PropertyName="setpoint_node_or_nodelist_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointNodeOrNodelistName { get; set; } = "";
        

        [Description("Optional input. Schedule allows scheduling of the outdoor air reset rule - a sche" +
                     "dule value of 1 means use the first rule; a value of 2 means use the second rule" +
                     ".")]
        [JsonProperty(PropertyName="schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ScheduleName { get; set; } = "";
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty(PropertyName="setpoint_at_outdoor_low_temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SetpointAtOutdoorLowTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty(PropertyName="outdoor_low_temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorLowTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty(PropertyName="setpoint_at_outdoor_high_temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SetpointAtOutdoorHighTemperature2 { get; set; } = null;
        

        [Description("2nd outdoor air temperature reset rule")]
        [JsonProperty(PropertyName="outdoor_high_temperature_2", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorHighTemperature2 { get; set; } = null;
    }
}