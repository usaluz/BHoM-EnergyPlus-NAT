using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    [Description(@"Unitary system, heating and cooling with constant volume supply fan (continuous or cycling), direct expansion (DX) cooling coil, heating coil (gas, electric, hot water, or steam), and optional reheat coil for dehumidification control. Identical to AirLoopHVAC:Unitary:Furnace:HeatCool.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_UnitaryHeatCool : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Availability schedule name for this system. Schedule value > 0 means the system i" +
                     "s available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="unitary_system_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitarySystemAirInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="unitary_system_air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UnitarySystemAirOutletNodeName { get; set; } = "";
        

        [Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to cycling fan mode for the entire simulation period.")]
        [JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="maximum_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> MaximumSupplyAirTemperature { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Must be less than or equal to the fan\'s maximum flow rate.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Must be less than or equal to the fan\'s maximum flow rate.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Must be less than or equal to the fan's maximum flow rate. Only used when fan operating mode is continuous (disregarded for cycling fan mode). This air flow rate is used when no heating or cooling is required (i.e., the DX coil compressor and heating coil are off). If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="controlling_zone_or_thermostat_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

        [Description("Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air" +
                     " fan operating mode schedule values not equal to 0).")]
        [JsonProperty(PropertyName="supply_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_SupplyFanObjectType), "FanConstantVolume");
        

        [JsonProperty(PropertyName="supply_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanName { get; set; } = "";
        

        [JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitaryHeatCool_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_FanPlacement), "BlowThrough");
        

        [Description("works with gas, electric, hot water and steam heating coils")]
        [JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_HeatingCoilObjectType), "CoilHeatingElectric");
        

        [JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingCoilName { get; set; } = "";
        

        [Description("Only works with DX cooling coil types or Coil:Cooling:DX:VariableSpeed.")]
        [JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_CoolingCoilObjectType), "CoilCoolingDXSingleSpeed");
        

        [JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilName { get; set; } = "";
        

        [Description(@"None = meet sensible load only Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted Cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
        [JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_DehumidificationControlType), "None");
        

        [Description("Only required if dehumidification control type is \"CoolReheat\" works with gas, el" +
                     "ectric, desuperheating, hot water and steam heating coils")]
        [JsonProperty(PropertyName="reheat_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType ReheatCoilObjectType { get; set; } = (AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitaryHeatCool_ReheatCoilObjectType), "CoilHeatingDesuperheater");
        

        [Description("Only required if dehumidification control type is \"CoolReheat\"")]
        [JsonProperty(PropertyName="reheat_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReheatCoilName { get; set; } = "";
    }
}