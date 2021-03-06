using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits
{
    [Description(@"Hybrid Unitary HVAC. A black box model for multi-mode packaged forced air equipment. Independent variables include outdoor air conditions and indoor air conditions. Controlled inputs include operating mode, supply air flow rate, and outdoor air faction. Emperical lookup tables are required to map supply air temperature supply air humidity, electricity use, fuel uses, water use, fan electricity use, and external static pressure as a function of each indpednent varaible and each controlled input. In each timestep the model will choose one or more combinations of settings for mode, supply air flow rate, outdoor air faction, and part runtime fraction so as to satisfy zone requests for sensible cooling, heating, ventilation, and/or dehumidification with the least resource consumption. Equipment in this class may consume electricity, water, and up to two additional fuel types.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ZoneHVAC_HybridUnitaryHVAC : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Enter the availability schedule name for this system. Schedule value > 0 means th" +
                     "e system is available. If this field is blank, the system is always available.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name of an AvailabilityManagerAssignmentList object.")]
        [JsonProperty(PropertyName="availability_manager_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityManagerListName { get; set; } = "";
        

        [Description("Values in this schedule are used as a constraint in choosing the feasible setting" +
                     "s for supply air flow rate and ouside air fraction in each operating mode. If th" +
                     "is field is blank, no minimum is imposed.")]
        [JsonProperty(PropertyName="minimum_supply_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumSupplyAirTemperatureScheduleName { get; set; } = "";
        

        [Description("Values in this schedule are used as a constraint in choosing the feasible setting" +
                     "s for supply air flow rate and outdoor air fraction in each operating mode. If t" +
                     "his field is blank, no maximum is imposed.")]
        [JsonProperty(PropertyName="maximum_supply_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumSupplyAirTemperatureScheduleName { get; set; } = "";
        

        [Description("Values in this schedule are used as a constraint in choosing the feasible setting" +
                     "s for supply air flow rate and outdoor air fraction in each operating mode. If t" +
                     "his field is blank, no minimum is imposed.")]
        [JsonProperty(PropertyName="minimum_supply_air_humidity_ratio_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumSupplyAirHumidityRatioScheduleName { get; set; } = "";
        

        [Description("Values in this schedule are used as a constraint in choosing the feasible setting" +
                     "s for supply air flow rate and outdoor air fraction in each operating mode. If t" +
                     "his field is blank, no maximum is imposed.")]
        [JsonProperty(PropertyName="maximum_supply_air_humidity_ratio_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MaximumSupplyAirHumidityRatioScheduleName { get; set; } = "";
        

        [Description(@"Select the method that will be used to choose operating mode(s), supply air flow rate(s), outdoor air fraction(s) and part runtime fraction(s) in each time step. ""Automatic"" = chooses controlled inputs and part runtime fraction(s) to minimize resource use within each time step while best satisfying requested sensible cooling, dehumidification and ventilation, and subject to constraints. ""User Defined"" = EMS will be used to choose controlled inputs and part runtime fraction(s) in each time step. If this field is blank, default to ""Automatic"".")]
        [JsonProperty(PropertyName="method_to_choose_controlled_inputs_and_part_runtime_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_MethodToChooseControlledInputsAndPartRuntimeFraction MethodToChooseControlledInputsAndPartRuntimeFraction { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_MethodToChooseControlledInputsAndPartRuntimeFraction)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_MethodToChooseControlledInputsAndPartRuntimeFraction), "Automatic");
        

        [Description("Return air node for the hybrid unit must be a zone exhaust node.")]
        [JsonProperty(PropertyName="return_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReturnAirNodeName { get; set; } = "";
        

        [Description("Outdoor air node for the hybrid unit must be an outdoor air node.")]
        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("Supply air node for the hybrid unit must be a zone air inlet node.")]
        [JsonProperty(PropertyName="supply_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SupplyAirNodeName { get; set; } = "";
        

        [Description("Relief node for the hybrid unit must be a zone exhaust node, unless flow is being" +
                     " balanced elsewhere.")]
        [JsonProperty(PropertyName="relief_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ReliefNodeName { get; set; } = "";
        

        [Description(@"The value in this field represents the maximum supply air volume flow rate among all operating modes. Values of extensive variables in lookup tables are normalized by the system maximum supply air mass flow rate that was used to build performance curves. The value in this field is used to rescale the output from exenstive variables to a desired system size.")]
        [JsonProperty(PropertyName="system_maximum_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SystemMaximumSupplyAirFlowRate { get; set; } = null;
        

        [Description(@"Input the external static pressure when the system operates at maximum supply air flow rate. Fan affinity laws are used to scale supply fan power from the values tabulated in lookup tables, to values that match the external static pressure input to this field. If this field is blank, the supply fan power is not scaled from the values tabulated in lookup tables.")]
        [JsonProperty(PropertyName="external_static_pressure_at_system_maximum_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ExternalStaticPressureAtSystemMaximumSupplyAirFlowRate { get; set; } = null;
        

        [Description("This field specifies if the fan heat is accounted for in the lookup tables.")]
        [JsonProperty(PropertyName="fan_heat_included_in_lookup_tables", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public EmptyNoYes FanHeatIncludedInLookupTables { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

        [Description("This field specifies where to add the fan heat in the air stream.")]
        [JsonProperty(PropertyName="fan_heat_gain_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_FanHeatGainLocation FanHeatGainLocation { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_FanHeatGainLocation)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_FanHeatGainLocation), "SupplyAirStream");
        

        [Description("0.0 means no fan heat is added to the air stream, 1.0 means all fan heat is added" +
                     " to the air stream.")]
        [JsonProperty(PropertyName="fan_heat_in_air_stream_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FanHeatInAirStreamFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("The value in this field scales all extensive performance variables including: sup" +
                     "ply air mass flow rate, fuel uses, and water use. If this field is blank, the de" +
                     "fault scaling factor is 1.")]
        [JsonProperty(PropertyName="scaling_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ScalingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Any mode selected will not operate for less time than the value input in this field. If the value in this field is larger than each timestep, the mode selected in one time step will persist in later time steps until the minimum time between mode change is satisfied. Supply air mass flow rate and outdoor air fraction within a mode are not subject to minimum runtime and may change in every time step. Mode 0 does not have a minimum time. If this field is blank, the default minimum time between mode change is 10 minutes.")]
        [JsonProperty(PropertyName="minimum_time_between_mode_change", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumTimeBetweenModeChange { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Select the fuel type associated with field: \"System Electric Power Lookup Table\" " +
                     "in each mode. If this field is blank, default first fuel type = Electricity.")]
        [JsonProperty(PropertyName="first_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_FirstFuelType FirstFuelType { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_FirstFuelType)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_FirstFuelType), "Electricity");
        

        [Description("Select the fuel type associated with field: \"System Second Fuel Consumption Looku" +
                     "p Table\" in each mode. If this field is blank, default second fuel type = None.")]
        [JsonProperty(PropertyName="second_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_SecondFuelType SecondFuelType { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_SecondFuelType)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_SecondFuelType), "None");
        

        [Description("Select the fuel type associated with field: \"System Third Fuel Consumption Lookup" +
                     " Table\" in each mode. If this field is blank, default third fuel type = None.")]
        [JsonProperty(PropertyName="third_fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_ThirdFuelType ThirdFuelType { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_ThirdFuelType)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_ThirdFuelType), "None");
        

        [Description("In each time step, controlled variables will be chosen to minimize the selection " +
                     "in this field, subject to constraints. If this field is blank, the objective fun" +
                     "ction will minimize electricity use.")]
        [JsonProperty(PropertyName="objective_function_to_minimize", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ZoneHVAC_HybridUnitaryHVAC_ObjectiveFunctionToMinimize ObjectiveFunctionToMinimize { get; set; } = (ZoneHVAC_HybridUnitaryHVAC_ObjectiveFunctionToMinimize)Enum.Parse(typeof(ZoneHVAC_HybridUnitaryHVAC_ObjectiveFunctionToMinimize), "Empty");
        

        [Description(@"Enter the name of a DesignSpecification:OutdoorAir object. Information in that object will be used to compute the minimum outdoor air flow rate in each time step. If this field is blank, the system may still supply outdoor air, if it is capable as described by lookup tables, when doing so is the most efficient way to satisfy other constraints.")]
        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description(@"Enter a name for Mode 0. Mode 0 describes equipment performance in standby. Mode 0 is usually characterized by electricity use for controls and crankcase heaters, or other standby resouce consumption. Mode 0 will be chosen for any timestep, or portion of timestep, when no ventilation, cooling, humidification, or dehumidification is required. Mode 0 is available at any environmental condition.")]
        [JsonProperty(PropertyName="mode_0_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0Name { get; set; } = "";
        

        [Description(@"Enter the name of the Supply Air Temperature Lookup Table for Mode 0. Units for lookup table values should be in C. If this field is blank, Mode 0 will not be considered for any period that requires ventilation, heating, cooling, humidification, or dehumidification. If this field is blank, when Mode 0 is chosen (during standby periods) the supply air temperature will equal the return air temperature.")]
        [JsonProperty(PropertyName="mode_0_supply_air_temperature_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SupplyAirTemperatureLookupTableName { get; set; } = "";
        

        [Description(@"Enter the name of the Supply Air Humidity Ratio Lookup Table for Mode 0. Units for lookup table values should be in kgWater/kgDryAir. If this field is blank, Mode 0 will not be considered for any period that requires ventilation, heating, cooling, humidification, or dehumidification. If this field is blank, when Mode 0 is chosen (during standby periods) the supply air humidty ratio will equal the return air humidity ratio.")]
        [JsonProperty(PropertyName="mode_0_supply_air_humidity_ratio_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SupplyAirHumidityRatioLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the Electric Power Lookup Table for Mode 0. Units for lookup ta" +
                     "ble values should be in W. If this field is blank, Mode 0 does not consume elect" +
                     "ricity.")]
        [JsonProperty(PropertyName="mode_0_system_electric_power_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SystemElectricPowerLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the Supply Fan Electric Power Lookup Table for Mode 0. Units fo" +
                     "r lookup table values should be in W. If this field is blank, Mode 0 does not co" +
                     "nsume electricity for supply fan.")]
        [JsonProperty(PropertyName="mode_0_supply_fan_electric_power_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SupplyFanElectricPowerLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the External Static Pressure Lookup Table for Mode 0. Units for" +
                     " lookup table values should be in Pa. If this field is blank, external static pr" +
                     "essure will not be reported.")]
        [JsonProperty(PropertyName="mode_0_external_static_pressure_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0ExternalStaticPressureLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the System Second Fuel Consumption Lookup Table for Mode 0. Uni" +
                     "ts for lookup table values should be in W. If this field is blank, Mode 0 does n" +
                     "ot consume a second fuel.")]
        [JsonProperty(PropertyName="mode_0_system_second_fuel_consumption_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SystemSecondFuelConsumptionLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the System Third Fuel Consumption Lookup Table for Mode 0. Unit" +
                     "s for lookup table values should be in W. If this field is blank, Mode 0 does no" +
                     "t consume a third fuel.")]
        [JsonProperty(PropertyName="mode_0_system_third_fuel_consumption_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SystemThirdFuelConsumptionLookupTableName { get; set; } = "";
        

        [Description("Enter the name of the System Water Use Lookup Table for Mode 0. Units for lookup " +
                     "table values should be in kg/s. If this field is blank, Mode 0 does not consume " +
                     "water.")]
        [JsonProperty(PropertyName="mode_0_system_water_use_lookup_table_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Mode0SystemWaterUseLookupTableName { get; set; } = "";
        

        [Description("Enter the outdoor air fraction for Mode 0. If this field is blank, the outdoor ai" +
                     "r fraction for Mode 0 will be 0.00.")]
        [JsonProperty(PropertyName="mode_0_outdoor_air_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Mode0OutdoorAirFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the supply air mass flow rate ratio for Mode 0. The value in this field will be used to determine the supply air mass flow rate in Mode 0. Supply air mass flow rate ratio describes supply air mass flow rate as a fraction of mass flow rate associated with the value in field: ""System Maximum Supply Air Flow Rate"". If this field is blank, the supply air mass flow rate ratio for Mode 0 will be 0.")]
        [JsonProperty(PropertyName="mode_0_supply_air_mass_flow_rate_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Mode0SupplyAirMassFlowRateRatio { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="modes", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits.ZoneHVAC_HybridUnitaryHVAC_Modes_Item> Modes { get; set; } = null;
    }
}