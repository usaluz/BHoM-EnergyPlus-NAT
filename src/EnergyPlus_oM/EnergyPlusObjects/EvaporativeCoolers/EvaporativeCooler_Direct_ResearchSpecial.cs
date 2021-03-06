using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.EvaporativeCoolers
{
    [Description("Direct evaporative cooler with user-specified effectiveness (can represent rigid " +
                 "pad or similar media), and recirculating water pump, and secondary air fan. This" +
                 " model is controlled to meet the primary air outlet temperature setpoint.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class EvaporativeCooler_Direct_ResearchSpecial : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("effectiveness with respect to wet-bulb depression")]
        [JsonProperty(PropertyName="cooler_design_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolerDesignEffectiveness { get; set; } = null;
        

        [Description(@"this curve modifies the design effectiveness in the previous field by multiplying the value by the result of this curve. The effectiveness flow modifier curve is a function of flow fraction. Flow fraction is the ratio of current primary air flow rate to the primary air design flow rate. If this input field is left blank then, the effectiveness is assumed to be constant.")]
        [JsonProperty(PropertyName="effectiveness_flow_ratio_modifier_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EffectivenessFlowRatioModifierCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="primary_air_design_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> PrimaryAirDesignFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This is the design water pump or spray for evaporation at the primary air design " +
                     "air flow rates and cooler design effectiveness")]
        [JsonProperty(PropertyName="recirculating_water_pump_design_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> RecirculatingWaterPumpDesignPower { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"This field is used when the previous field is set to autosize. The pump power is scaled with Primary Air Design Air Flow Rate. This value was backed out from inputs in energy plus example files. Average Pump Power sizing factor was estimated from pump power and primary air design flow rates inputs from energyplus example files is about 90.0 [W/(m3/s)] (=90.0 ~ Pump Power / Primary Air Design Flow Rate). The factor ranges from 55.0 to 150.0 [W/(m3/s)]. The pump power can be sized to zero by setting this factor to zero.")]
        [JsonProperty(PropertyName="water_pump_power_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterPumpPowerSizingFactor { get; set; } = Double.Parse("90", CultureInfo.InvariantCulture);
        

        [Description(@"this curve modifies the pump power in the previous field by multiplying the design power by the result of this curve. x = ff = flow fraction on the primary air. The flow fraction is the primary air flow rate during current operation divided by Primary Air Design Flow Rate")]
        [JsonProperty(PropertyName="water_pump_power_modifier_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterPumpPowerModifierCurveName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="sensor_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SensorNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="water_supply_storage_tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterSupplyStorageTankName { get; set; } = "";
        

        [Description("Rate of drift loss as a fraction of evaporated water flow rate")]
        [JsonProperty(PropertyName="drift_loss_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DriftLossFraction { get; set; } = null;
        

        [Description(@"Characterizes the rate of blowdown in the evaporative cooler. Blowdown is water intentionally drained from the cooler in order to offset the build up of solids in the water that would otherwise occur because of evaporation. Ratio of solids in the blowdown water to solids in the make up water. A typical value is 3. If left blank then there is no blowdown.")]
        [JsonProperty(PropertyName="blowdown_concentration_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BlowdownConcentrationRatio { get; set; } = null;
        

        [Description(@"This numeric field defines the evaporative cooler air inlet node drybulb temperature minimum limit in degrees Celsius. The evaporative cooler will be turned off when the evaporator cooler air inlet node dry-bulb temperature falls below this limit. The typical minimum value is 16degC. Users are allowed to specify their own limits. If this field is left blank, then there is no drybulb lower temperature limit for evaporative cooler operation.")]
        [JsonProperty(PropertyName="evaporative_operation_minimum_drybulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeOperationMinimumDrybulbTemperature { get; set; } = null;
        

        [Description(@"when outdoor wetbulb temperature rises above this limit the cooler shuts down. This numeric field defines the evaporative cooler air inlet node wet-bulb temperature maximum limit in degrees Celsius. The evaporative cooler will be turned off when the evaporative cooler air inlet node wet-bulb temperature exceeds this limit. The typical maximum value is 24degC. Users are allowed to specify their own limits. If this field is left blank, then there is no upper wetbulb temperature limit for evaporative cooler operation.")]
        [JsonProperty(PropertyName="evaporative_operation_maximum_limit_wetbulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeOperationMaximumLimitWetbulbTemperature { get; set; } = null;
        

        [Description(@"This numeric field defines the evaporative cooler air inlet node dry-bulb temperature maximum limit in degrees Celsius. The evaporative cooler will be turned off when its air inlet node drybulb temperature exceeds this limit. The typical maximum value is 26degC. Users are allowed to specify their own limits. If this field is left blank, then there is no upper temperature limit for evaporative cooler operation.")]
        [JsonProperty(PropertyName="evaporative_operation_maximum_limit_drybulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeOperationMaximumLimitDrybulbTemperature { get; set; } = null;
    }
}