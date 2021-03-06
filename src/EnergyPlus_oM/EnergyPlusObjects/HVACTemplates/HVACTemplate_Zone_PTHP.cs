using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    [Description("Packaged Terminal Heat Pump")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class HVACTemplate_Zone_PTHP : BHoMObject
    {
        

        [Description("Zone name must match a building zone name")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description("Enter the name of a HVACTemplate:Thermostat object. If blank, then it is assumed " +
                     "that standard thermostat objects have been defined for this zone.")]
        [JsonProperty(PropertyName="template_thermostat_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TemplateThermostatName { get; set; } = "";
        

        [Description("Supply air flow rate during cooling operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Supply air flow rate during heating operation This field may be set to \"autosize\"" +
                     ". If a value is entered, it will be multiplied by the Supply Air Sizing Factor a" +
                     "nd by zone multipliers.")]
        [JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Supply air flow rate when no cooling or heating is needed Only used when heat pump fan operating mode is continuous. This air flow rate is used when no heating or cooling is required and the DX coil compressor is off. If this field is left blank or zero, the supply air flow rate from the previous on cycle (either cooling or heating) is used. A value entered in this field will *not* be multiplied by the sizing factor or by zone multipliers. It is best to autosize or leave blank when using zone multipliers.")]
        [JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_heating_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingSizingFactor { get; set; } = null;
        

        [Description("If blank, value from Sizing:Parameters will be used.")]
        [JsonProperty(PropertyName="zone_cooling_sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingSizingFactor { get; set; } = null;
        

        [Description(@"Flow/Person, Flow/Zone, Flow/Area, Sum, and Maximum use the values in the next three fields: Outdoor Air Flow Rate per Person, Outdoor Air Flow Rate per Zone Floor Area, and Outdoor Air Flow Rate per Zone. DetailedSpecification ignores these three Outdoor Air Flow Rate fields and instead references design specification objects named in the fields Design Specification Outdoor Air Object Name and Design Specification Zone Air Distribution Object Name.")]
        [JsonProperty(PropertyName="outdoor_air_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_OutdoorAirMethod OutdoorAirMethod { get; set; } = (HVACTemplate_Zone_PTHP_OutdoorAirMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_OutdoorAirMethod), "Empty");
        

        [Description("Default 0.00944 is 20 cfm per person This input is used if the field Outdoor Air " +
                     "Method is Flow/Person, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_person", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerPerson { get; set; } = Double.Parse("0.00944", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Area, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_zone_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerZoneFloorArea { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This input is used if the field Outdoor Air Method is Flow/Zone, Sum, or Maximum")]
        [JsonProperty(PropertyName="outdoor_air_flow_rate_per_zone", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OutdoorAirFlowRatePerZone { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="system_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SystemAvailabilityScheduleName { get; set; } = "";
        

        [Description("Refers to a schedule to specify unitary supply fan operating mode. Schedule value" +
                     "s of 0 indicate cycling fan (auto) Schedule values of 1 indicate continuous fan " +
                     "(on) If this field is left blank, a schedule of always zero (cycling fan) will b" +
                     "e used.")]
        [JsonProperty(PropertyName="supply_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyFanOperatingModeScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supply_fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_SupplyFanPlacement SupplyFanPlacement { get; set; } = (HVACTemplate_Zone_PTHP_SupplyFanPlacement)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplyFanPlacement), "DrawThrough");
        

        [JsonProperty(PropertyName="supply_fan_total_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanTotalEfficiency { get; set; } = Double.Parse("0.7", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_delta_pressure", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanDeltaPressure { get; set; } = Double.Parse("75", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supply_fan_motor_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplyFanMotorEfficiency { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="cooling_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_CoolingCoilType CoolingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_CoolingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CoolingCoilType), "SingleSpeedDX");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="cooling_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CoolingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Total cooling capacity not accounting for the effect of supply air fan heat Ratin" +
                     "g point: air entering the cooling coil at 26.7 C dry-bulb/19.4 C wet-bulb, and a" +
                     "ir entering the outdoor condenser coil at 35 C dry-bulb/23.9 C wet-bulb")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_total_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedTotalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) Sensible" +
                     " and total capacities do not include effect of supply fan heat")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> CoolingCoilGrossRatedSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and outdoor fan, " +
                     "does not include supply fan heat or supply fan electrical energy input")]
        [JsonProperty(PropertyName="cooling_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CoolingCoilGrossRatedCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType HeatPumpHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpHeatingCoilType), "SingleSpeedDXHeatPump");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatPumpHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [Description("Capacity excluding supply air fan heat Rating point outdoor dry-bulb temp 8.33 C," +
                     " outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21" +
                     ".11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description(@"Heat Pump Heating Coil Rated Capacity divided by power input to the compressor and outdoor fan, Does not include supply air fan heat or supply air fan electrical energy Rating point outdoor dry-bulb temp 8.33 C, outdoor wet-bulb temp 6.11 C Rating point heating coil entering air dry-bulb 21.11 C, coil entering wet-bulb 15.55 C")]
        [JsonProperty(PropertyName="heat_pump_heating_coil_gross_rated_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpHeatingCoilGrossRatedCop { get; set; } = Double.Parse("2.75", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_heating_minimum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpHeatingMinimumOutdoorDryBulbTemperature { get; set; } = Double.Parse("-8", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_defrost_maximum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpDefrostMaximumOutdoorDryBulbTemperature { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_pump_defrost_strategy", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy HeatPumpDefrostStrategy { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostStrategy), "ReverseCycle");
        

        [JsonProperty(PropertyName="heat_pump_defrost_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_HeatPumpDefrostControl HeatPumpDefrostControl { get; set; } = (HVACTemplate_Zone_PTHP_HeatPumpDefrostControl)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_HeatPumpDefrostControl), "Timed");
        

        [Description("Fraction of time in defrost mode only applicable if Timed defrost control is spec" +
                     "ified")]
        [JsonProperty(PropertyName="heat_pump_defrost_time_period_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatPumpDefrostTimePeriodFraction { get; set; } = Double.Parse("0.058333", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="supplemental_heating_coil_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType SupplementalHeatingCoilType { get; set; } = (HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_SupplementalHeatingCoilType), "Electric");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="supplemental_heating_coil_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplementalHeatingCoilAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="supplemental_heating_coil_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> SupplementalHeatingCoilCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Supplemental heater will not operate when outdoor temperature exceeds this value." +
                     "")]
        [JsonProperty(PropertyName="supplemental_heating_coil_maximum_outdoor_dry_bulb_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalHeatingCoilMaximumOutdoorDryBulbTemperature { get; set; } = Double.Parse("21", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty(PropertyName="supplemental_gas_heating_coil_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalGasHeatingCoilEfficiency { get; set; } = Double.Parse("0.8", CultureInfo.InvariantCulture);
        

        [Description("Applies only if Supplemental Heating Coil Type is Gas")]
        [JsonProperty(PropertyName="supplemental_gas_heating_coil_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SupplementalGasHeatingCoilParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Enter the name of an HVACTemplate:System:DedicatedOutdoorAir object if this zone " +
                     "is served by a separate dedicated outdoor air system (DOAS). Leave field blank i" +
                     "f no DOAS serves this zone.")]
        [JsonProperty(PropertyName="dedicated_outdoor_air_system_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DedicatedOutdoorAirSystemName { get; set; } = "";
        

        [Description("SupplyAirTemperature = use the value from Zone Cooling Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Cooling Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod ZoneCoolingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneCoolingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperature { get; set; } = Double.Parse("14", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Cooling Design Supply Air Temperature is only used when Zone Cooling Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be subtracted from the zone temperature at peak load to calculate the Zone Cooling Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_cooling_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneCoolingDesignSupplyAirTemperatureDifference { get; set; } = Double.Parse("11.11", CultureInfo.InvariantCulture);
        

        [Description("SupplyAirTemperature = use the value from Zone Heating Design Supply Air Temperat" +
                     "ure TemperatureDifference = use the value from Zone Heating Design Supply Air Te" +
                     "mperature Difference")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_input_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod ZoneHeatingDesignSupplyAirTemperatureInputMethod { get; set; } = (HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_ZoneHeatingDesignSupplyAirTemperatureInputMethod), "SupplyAirTemperature");
        

        [Description("Zone Heating Design Supply Air Temperature is only used when Zone Heating Design " +
                     "Supply Air Temperature Input Method = SupplyAirTemperature")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperature { get; set; } = Double.Parse("50", CultureInfo.InvariantCulture);
        

        [Description(@"Zone Heating Design Supply Air Temperature is only used when Zone Heating Design Supply Air Temperature Input Method = TemperatureDifference The absolute value of this field will be added to the zone temperature at peak load to calculate the Zone Heating Design Supply Air Temperature.")]
        [JsonProperty(PropertyName="zone_heating_design_supply_air_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneHeatingDesignSupplyAirTemperatureDifference { get; set; } = Double.Parse("30", CultureInfo.InvariantCulture);
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("This field is used only when Outdoor Air Method=DetailedSpecification.")]
        [JsonProperty(PropertyName="design_specification_zone_air_distribution_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationZoneAirDistributionObjectName { get; set; } = "";
        

        [JsonProperty(PropertyName="baseboard_heating_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_BaseboardHeatingType BaseboardHeatingType { get; set; } = (HVACTemplate_Zone_PTHP_BaseboardHeatingType)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_BaseboardHeatingType), "None");
        

        [Description("If blank, always on")]
        [JsonProperty(PropertyName="baseboard_heating_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaseboardHeatingAvailabilityScheduleName { get; set; } = "";
        

        [JsonProperty(PropertyName="baseboard_heating_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> BaseboardHeatingCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="capacity_control_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public HVACTemplate_Zone_PTHP_CapacityControlMethod CapacityControlMethod { get; set; } = (HVACTemplate_Zone_PTHP_CapacityControlMethod)Enum.Parse(typeof(HVACTemplate_Zone_PTHP_CapacityControlMethod), "None");
    }
}