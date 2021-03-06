using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Controllers
{
    [Description("Controller to set the outdoor air flow rate for an air loop. Control options incl" +
                 "ude fixed, proportional, scheduled, economizer, and demand-controlled ventilatio" +
                 "n.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Controller_OutdoorAir : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="relief_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReliefAirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="return_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="mixed_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedAirNodeName { get; set; } = "";
        

        [Description("Outdoor air inlet node entering the first pre-treat component if any")]
        [JsonProperty(PropertyName="actuator_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ActuatorNodeName { get; set; } = "";
        

        [Description("If there is a Mechanical Ventilation Controller (Controller:MechanicalVentilation" +
                     "), note that this value times the Minimum Outdoor Air Schedule is a hard minimum" +
                     " that may override DCV or other advanced OA controls.")]
        [JsonProperty(PropertyName="minimum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MinimumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_outdoor_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumOutdoorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="economizer_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_OutdoorAir_EconomizerControlType EconomizerControlType { get; set; } = (Controller_OutdoorAir_EconomizerControlType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlType), "NoEconomizer");
        

        [JsonProperty(PropertyName="economizer_control_action_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_OutdoorAir_EconomizerControlActionType EconomizerControlActionType { get; set; } = (Controller_OutdoorAir_EconomizerControlActionType)Enum.Parse(typeof(Controller_OutdoorAir_EconomizerControlActionType), "ModulateFlow");
        

        [Description("Enter the maximum outdoor dry-bulb temperature limit for FixedDryBulb economizer " +
                     "control type. No input or blank input means this limit is not operative. Limit i" +
                     "s applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitDryBulbTemperature { get; set; } = null;
        

        [Description("Enter the maximum outdoor enthalpy limit for FixedEnthalpy economizer control typ" +
                     "e. No input or blank input means this limit is not operative Limit is applied re" +
                     "gardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_enthalpy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitEnthalpy { get; set; } = null;
        

        [Description("Enter the maximum outdoor dewpoint temperature limit for FixedDewPointAndDryBulb " +
                     "economizer control type. No input or blank input means this limit is not operati" +
                     "ve. Limit is applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="economizer_maximum_limit_dewpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMaximumLimitDewpointTemperature { get; set; } = null;
        

        [Description(@"Enter the name of a quadratic or cubic curve which defines the maximum outdoor humidity ratio (function of outdoor dry-bulb temperature) for ElectronicEnthalpy economizer control type. No input or blank input means this limit is not operative Limit is applied regardless of economizer control type.")]
        [JsonProperty(PropertyName="electronic_enthalpy_limit_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectronicEnthalpyLimitCurveName { get; set; } = "";
        

        [Description("Enter the minimum outdoor dry-bulb temperature limit for economizer control. No i" +
                     "nput or blank input means this limit is not operative Limit is applied regardles" +
                     "s of economizer control type.")]
        [JsonProperty(PropertyName="economizer_minimum_limit_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EconomizerMinimumLimitDryBulbTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="lockout_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_OutdoorAir_LockoutType LockoutType { get; set; } = (Controller_OutdoorAir_LockoutType)Enum.Parse(typeof(Controller_OutdoorAir_LockoutType), "NoLockout");
        

        [JsonProperty(PropertyName="minimum_limit_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_OutdoorAir_MinimumLimitType MinimumLimitType { get; set; } = (Controller_OutdoorAir_MinimumLimitType)Enum.Parse(typeof(Controller_OutdoorAir_MinimumLimitType), "ProportionalMinimum");
        

        [Description("Schedule values multiply the minimum outdoor air flow rate")]
        [JsonProperty(PropertyName="minimum_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the design/mixed air flow rate")]
        [JsonProperty(PropertyName="minimum_fraction_of_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

        [Description("schedule values multiply the design/mixed air flow rate")]
        [JsonProperty(PropertyName="maximum_fraction_of_outdoor_air_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumFractionOfOutdoorAirScheduleName { get; set; } = "";
        

        [Description("Enter the name of a Controller:MechanicalVentilation object. Optional field for d" +
                     "efining outdoor ventilation air based on flow rate per unit floor area and flow " +
                     "rate per person. Simplified method of demand-controlled ventilation.")]
        [JsonProperty(PropertyName="mechanical_ventilation_controller_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalVentilationControllerName { get; set; } = "";
        

        [Description(@"Optional schedule to simulate ""push-button"" type economizer control. Schedule values greater than 0 indicate time-of-day economizer control is enabled. Economizer control may be used with or without the high humidity control option. When used together, high humidity control has priority over economizer control. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
        [JsonProperty(PropertyName="time_of_day_economizer_control_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeOfDayEconomizerControlScheduleName { get; set; } = "";
        

        [Description(@"Optional field to enable modified outdoor air flow rates based on zone relative humidity. Select Yes to modify outdoor air flow rate based on a zone humidistat. Select No to disable this feature. If the field Economizer Control Type = NoEconomizer, then this option is disabled.")]
        [JsonProperty(PropertyName="high_humidity_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes HighHumidityControl { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("Enter the name of the zone where the humidistat is located. This field is only us" +
                     "ed when the field High Humidity Control = Yes.")]
        [JsonProperty(PropertyName="humidistat_control_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HumidistatControlZoneName { get; set; } = "";
        

        [Description("Enter the ratio of outdoor air to the maximum outdoor air flow rate when modified" +
                     " air flow rates are active based on high indoor humidity. The minimum value must" +
                     " be greater than 0. This field is only used when the field High Humidity Control" +
                     " = Yes.")]
        [JsonProperty(PropertyName="high_humidity_outdoor_air_flow_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HighHumidityOutdoorAirFlowRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"If No is selected, the outdoor air flow rate is modified any time indoor relative humidity is above the humidistat setpoint. If Yes is selected, the outdoor air flow rate is modified any time the indoor relative humidity is above the humidistat setpoint and the outdoor humidity ratio is less than the indoor humidity ratio. This field is only used when the field High Humidity Control = Yes.")]
        [JsonProperty(PropertyName="control_high_indoor_humidity_based_on_outdoor_humidity_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes ControlHighIndoorHumidityBasedOnOutdoorHumidityRatio { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "Yes");
        

        [Description(@"BypassWhenWithinEconomizerLimits specifies that heat recovery is active only when the economizer is off because conditions are outside the economizer control limits BypassWhenOAFlowGreaterThanMinimum specifies enhanced economizer controls to allow heat recovery when economizer is active (within limits) but the outdoor air flow rate is at the minimum.")]
        [JsonProperty(PropertyName="heat_recovery_bypass_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Controller_OutdoorAir_HeatRecoveryBypassControlType HeatRecoveryBypassControlType { get; set; } = (Controller_OutdoorAir_HeatRecoveryBypassControlType)Enum.Parse(typeof(Controller_OutdoorAir_HeatRecoveryBypassControlType), "BypassWhenWithinEconomizerLimits");
    }
}