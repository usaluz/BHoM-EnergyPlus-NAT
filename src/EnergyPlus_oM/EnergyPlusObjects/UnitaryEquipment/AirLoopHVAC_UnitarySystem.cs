namespace BH.oM.Adapters.EnergyPlus.UnitaryEquipment
{
    using System.ComponentModel;
    using BH.oM.Adapters.EnergyPlus;
    using System;
    using System.Globalization;
    using Newtonsoft.Json;
    using BH.oM.Base;
    using BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts;
    using BH.oM.Adapters.EnergyPlus.AirDistribution;
    using BH.oM.Adapters.EnergyPlus.AirflowNetwork;
    using BH.oM.Adapters.EnergyPlus.Coils;
    using BH.oM.Adapters.EnergyPlus.ComplianceObjects;
    using BH.oM.Adapters.EnergyPlus.CondenserEquipmentandHeatExchangers;
    using BH.oM.Adapters.EnergyPlus.Controllers;
    using BH.oM.Adapters.EnergyPlus.Daylighting;
    using BH.oM.Adapters.EnergyPlus.DemandLimitingControls;
    using BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer;
    using BH.oM.Adapters.EnergyPlus.Economics;
    using BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications;
    using BH.oM.Adapters.EnergyPlus.EnergyManagementSystemEMS;
    using BH.oM.Adapters.EnergyPlus.EvaporativeCoolers;
    using BH.oM.Adapters.EnergyPlus.ExteriorEquipment;
    using BH.oM.Adapters.EnergyPlus.ExternalInterface;
    using BH.oM.Adapters.EnergyPlus.Fans;
    using BH.oM.Adapters.EnergyPlus.FluidProperties;
    using BH.oM.Adapters.EnergyPlus.GeneralDataEntry;
    using BH.oM.Adapters.EnergyPlus.HeatRecovery;
    using BH.oM.Adapters.EnergyPlus.HumidifiersandDehumidifiers;
    using BH.oM.Adapters.EnergyPlus.HVACDesignObjects;
    using BH.oM.Adapters.EnergyPlus.HVACTemplates;
    using BH.oM.Adapters.EnergyPlus.HybridModel;
    using BH.oM.Adapters.EnergyPlus.InternalGains;
    using BH.oM.Adapters.EnergyPlus.LocationandClimate;
    using BH.oM.Adapters.EnergyPlus.NodeBranchManagement;
    using BH.oM.Adapters.EnergyPlus.NonZoneEquipment;
    using BH.oM.Adapters.EnergyPlus.OperationalFaults;
    using BH.oM.Adapters.EnergyPlus.OutputReporting;
    using BH.oM.Adapters.EnergyPlus.Parametrics;
    using BH.oM.Adapters.EnergyPlus.PerformanceCurves;
    using BH.oM.Adapters.EnergyPlus.PerformanceTables;
    using BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserFlowControl;
    using BH.oM.Adapters.EnergyPlus.PlantCondenserLoops;
    using BH.oM.Adapters.EnergyPlus.Pumps;
    using BH.oM.Adapters.EnergyPlus.PythonPluginSystem;
    using BH.oM.Adapters.EnergyPlus.Refrigeration;
    using BH.oM.Adapters.EnergyPlus.RoomAirModels;
    using BH.oM.Adapters.EnergyPlus.Schedules;
    using BH.oM.Adapters.EnergyPlus.SetpointManagers;
    using BH.oM.Adapters.EnergyPlus.SimulationParameters;
    using BH.oM.Adapters.EnergyPlus.SolarCollectors;
    using BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements;
    using BH.oM.Adapters.EnergyPlus.SystemAvailabilityManagers;
    using BH.oM.Adapters.EnergyPlus.ThermalZonesandSurfaces;
    using BH.oM.Adapters.EnergyPlus.UserDefinedHVACandPlantComponentModels;
    using BH.oM.Adapters.EnergyPlus.VariableRefrigerantFlowEquipment;
    using BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage;
    using BH.oM.Adapters.EnergyPlus.WaterSystems;
    using BH.oM.Adapters.EnergyPlus.ZoneAirflow;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACControlsandThermostats;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACEquipmentConnections;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACForcedAirUnits;
    using BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits;
    
    
    [Description(@"AirloopHVAC:UnitarySystem is a generic HVAC system type that allows any configuration of coils and/or fan. This object is a replacement of other AirloopHVAC objects. This object can be used in outdoor air systems, outdoor air units, air loops, and as zone equipment if desired.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirLoopHVAC_UnitarySystem : BHoMObject, IEnergyPlusNode
    {
        

[Description("This will be the main key of this instance. It will be the main key of the serial" +
    "ization and all other properties will be sub properties of this key.")]
[JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string NodeName { get; set; } = "";
        

[Description(@"Load control requires a Controlling Zone name. SetPoint control requires set points at coil outlet node. SingleZoneVAV also requires a Controlling Zone name and allows load control at low speed fan until the load exceeds capacity or outlet air temperature limits. The fan speed is then increased.")]
[JsonProperty(PropertyName="control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_ControlType ControlType { get; set; } = (AirLoopHVAC_UnitarySystem_ControlType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_ControlType), "Load");
        

[Description("Used only for Load based control Zone name where thermostat is located. Required " +
    "when Control Type = Load.")]
[JsonProperty(PropertyName="controlling_zone_or_thermostat_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string ControllingZoneOrThermostatLocation { get; set; } = "";
        

[Description(@"None = meet sensible load only. Required when Control Type = SingleZoneVAV. Multimode = activate enhanced dehumidification mode as needed and meet sensible load. Valid only with cooling coil type Coil:Cooling:DX:TwoStageWithHumidityControlMode or CoilSystem:Cooling:DX:HeatExchangerAssisted. This control mode either switches the coil mode or allows the heat exchanger to be turned on and off based on the zone dehumidification requirements. A ZoneControl:Humidistat object is also required. CoolReheat = cool beyond the dry-bulb setpoint. as required to meet the humidity setpoint. Valid with all cooling coil types. When a heat exchanger assisted cooling coil is used, the heat exchanger is locked on at all times. A ZoneControl:Humidistat object is also required.")]
[JsonProperty(PropertyName="dehumidification_control_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_DehumidificationControlType DehumidificationControlType { get; set; } = (AirLoopHVAC_UnitarySystem_DehumidificationControlType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_DehumidificationControlType), "None");
        

[Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. A schedule value greater than zero (usually 1 is used) indicates that the unit is available to operate as needed. A value less than or equal to zero (usually zero is used) denotes that the unit must be off.")]
[JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AvailabilityScheduleName { get; set; } = "";
        

[Description("Enter the node name used as the inlet air node for the unitary system.")]
[JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirInletNodeName { get; set; } = "";
        

[Description("Enter the node name used as the outlet air node for the unitary system.")]
[JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string AirOutletNodeName { get; set; } = "";
        

[Description(@"Enter the type of supply air fan if included in the unitary system. Fan:ConstantVolume only works with continuous fan operating mode (i.e. supply air fan operating mode schedule values greater than 0). Specify a Fan:SystemModel or a Fan:OnOff object when the Supply Air Fan Operating Mode Schedule Name input field above is left blank. Specify a Fan:SystemModel or a Fan:VariableVolume when modeling VAV systems which used setpoint based control if the fan is included in the unitary system object. The ComponentModel fan type may be substituted for the ConstantVolume or VariableVolume fan types when more detailed fan modeling is required. The variable or constant volume fan may be specified on the branch instead of contained within the unitary system object (i.e., this field may be blank for certain configurations).")]
[JsonProperty(PropertyName="supply_fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_SupplyFanObjectType SupplyFanObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_SupplyFanObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_SupplyFanObjectType), "FanComponentModel");
        

[Description("Enter the name of the supply air fan if included in the unitary system.")]
[JsonProperty(PropertyName="supply_fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyFanName { get; set; } = "";
        

[Description("Enter the type of supply air fan if included in the unitary system.")]
[JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_FanPlacement FanPlacement { get; set; } = (AirLoopHVAC_UnitarySystem_FanPlacement)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_FanPlacement), "BlowThrough");
        

[Description(@"A fan operating mode schedule value of 0 indicates cycling fan mode (supply air fan cycles on and off in tandem with the cooling or heating coil). Any other schedule value indicates continuous fan mode (supply air fan operates continuously regardless of cooling or heating coil operation). Provide a schedule with non-zero values when high humidity control is specified. Leaving this schedule name blank will default to constant fan mode for the entire simulation period. This field is not used when set point based control is used where a set point controls the coil. SingleZoneVAV control type is only active when constant fan operating mode is active.")]
[JsonProperty(PropertyName="supply_air_fan_operating_mode_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplyAirFanOperatingModeScheduleName { get; set; } = "";
        

[Description("Enter the type of heating coil if included in the unitary system.")]
[JsonProperty(PropertyName="heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_HeatingCoilObjectType HeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_HeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_HeatingCoilObjectType), "CoilHeatingDXMultiSpeed");
        

[Description("Enter the name of the heating coil if included in the unitary system.")]
[JsonProperty(PropertyName="heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string HeatingCoilName { get; set; } = "";
        

[Description("Used to adjust heat pump heating capacity with respect to DX cooling capacity use" +
    "d only for heat pump configurations (i.e., a DX cooling and DX heating coil is u" +
    "sed).")]
[JsonProperty(PropertyName="dx_heating_coil_sizing_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DxHeatingCoilSizingRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

[Description("Enter the type of cooling coil if included in the unitary system.")]
[JsonProperty(PropertyName="cooling_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_CoolingCoilObjectType CoolingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_CoolingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_CoolingCoilObjectType), "CoilCoolingDX");
        

[Description("Enter the name of the cooling coil if included in the unitary system.")]
[JsonProperty(PropertyName="cooling_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string CoolingCoilName { get; set; } = "";
        

[Description("If Yes, the DX cooling coil runs as 100% DOAS DX coil. If No, the DX cooling coil" +
    " runs as a regular DX coil. If left blank the default is regular dx coil.")]
[JsonProperty(PropertyName="use_doas_dx_cooling_coil", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public EmptyNoYes UseDoasDxCoolingCoil { get; set; } = (EmptyNoYes)Enum.Parse(typeof(EmptyNoYes), "No");
        

[Description(@"When Use DOAS DX Cooling Coil is specified as Yes, Minimum Supply Air Temperature defines the minimum DOAS DX cooling coil leaving air temperature that should be maintained to avoid frost formation. This field is not autosizable when the input for Use DOAS DX Cooling Coil = Yes. When Control Type = SingleZoneVAV, enter the minimum air temperature limit for reduced fan speed.")]
[JsonProperty(PropertyName="minimum_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> MinimumSupplyAirTemperature { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description(@"SensibleOnlyLoadControl is selected when thermostat or SingleZoneVAV control is used. LatentOnlyLoadControl is selected when humidistat control is used. LatentWithSensibleLoadControl is selected when thermostat control is used and dehumidification is required only when a sensible load exists. LatentOrSensibleLoadControl is selected when thermostat control is used and dehumidification is required any time the humidistat set point is exceeded.")]
[JsonProperty(PropertyName="latent_load_control", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_LatentLoadControl LatentLoadControl { get; set; } = (AirLoopHVAC_UnitarySystem_LatentLoadControl)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_LatentLoadControl), "SensibleOnlyLoadControl");
        

[Description(@"Enter the type of supplemental heating or reheat coil if included in the unitary system. Only required if dehumidification control type is ""CoolReheat"". This coil supplements heating mode operation or reheats the supply air during dehumidification mode operation. If set point based control is used the coils operate to meet their respective supply air temperature set point.")]
[JsonProperty(PropertyName="supplemental_heating_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType SupplementalHeatingCoilObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_SupplementalHeatingCoilObjectType), "CoilHeatingDesuperheater");
        

[Description("Enter the name of the supplemental heating coil if included in the unitary system" +
    ". Only required if dehumidification control type is \"CoolReheat\".")]
[JsonProperty(PropertyName="supplemental_heating_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string SupplementalHeatingCoilName { get; set; } = "";
        

[Description(@"Enter the method used to determine the cooling supply air volume flow rate. None is used when a cooling coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedCoolingValue is selected when the supply air volume is a fraction of the value determined by the simulation. FlowPerCoolingCapacity is selected when the supply air volume is a fraction of the cooling capacity as determined by the simulation.")]
[JsonProperty(PropertyName="cooling_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod CoolingSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_CoolingSupplyAirFlowRateMethod), "FlowPerCoolingCapacity");
        

[Description("Enter the magnitude of the supply air volume flow rate during cooling operation. " +
    "Required field when Cooling Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
    "is field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty(PropertyName="cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> CoolingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when Cooling Supply Air Flow Rate Method is FlowPerFloorArea. This field may " +
    "be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CoolingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the cooling supply air flow rate. Required field when Cooling Supply Air Flow Rate Method is FractionOfAutosizedCoolingValue. This field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty(PropertyName="cooling_fraction_of_autosized_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CoolingFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity. Requ" +
    "ired field when Cooling Supply Air Flow Rate Method is FlowPerCoolingCapacity. T" +
    "his field may be blank if a cooling coil is not included in the unitary system.")]
[JsonProperty(PropertyName="cooling_supply_air_flow_rate_per_unit_of_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> CoolingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the heating supply air volume flow rate. None is used when a heating coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedHeatingValue is selected when the supply air volume is a fraction of the value determined by the simulation. FlowPerHeatingCapacity is selected when the supply air volume is a fraction of the heating capacity as determined by the simulation.")]
[JsonProperty(PropertyName="heating_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod HeatingSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_HeatingSupplyAirFlowRateMethod), "FlowPerFloorArea");
        

[Description("Enter the magnitude of the supply air volume flow rate during heating operation. " +
    "Required field when Heating Supply Air Flow Rate Method is SupplyAirFlowRate. Th" +
    "is field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty(PropertyName="heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> HeatingSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when Heating Supply Air Flow Rate Method is FlowPerFloorArea. This field may " +
    "be blank if a heating coil is not included in the unitary system.")]
[JsonProperty(PropertyName="heating_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatingSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description(@"Enter the supply air volume flow rate as a fraction of the heating supply air flow rate. Required field when Heating Supply Air Flow Rate Method is FractionOfAutosizedHeatingValue. This field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty(PropertyName="heating_fraction_of_autosized_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatingFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating capacity. Requ" +
    "ired field when Heating Supply Air Flow Rate Method is FlowPerHeatingCapacity. T" +
    "his field may be blank if a heating coil is not included in the unitary system.")]
[JsonProperty(PropertyName="heating_supply_air_flow_rate_per_unit_of_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatingSupplyAirFlowRatePerUnitOfCapacity { get; set; } = null;
        

[Description(@"Enter the method used to determine the supply air volume flow rate when no cooling or heating is required. None is used when a cooling and heating coil is not included in the unitary system or this field may be blank. SupplyAirFlowRate is selected when the magnitude of the supply air volume is used. FlowPerFloorArea is selected when the supply air volume flow rate is based on total floor area served by the unitary system. FractionOfAutosizedCoolingValue is selected when the supply air volume is a fraction of the cooling value determined by the simulation. FractionOfAutosizedHeatingValue is selected when the supply air volume is a fraction of the heating value determined by the simulation. FlowPerCoolingCapacity is selected when the supply air volume is a fraction of the cooling capacity as determined by the simulation. FlowPerHeatingCapacity is selected when the supply air volume is a fraction of the heating capacity as determined by the simulation.")]
[JsonProperty(PropertyName="no_load_supply_air_flow_rate_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod NoLoadSupplyAirFlowRateMethod { get; set; } = (AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_NoLoadSupplyAirFlowRateMethod), "FlowPerCoolingCapacity");
        

[Description("Enter the magnitude of the supply air volume flow rate during when no cooling or " +
    "heating is required. Required field when No Load Supply Air Flow Rate Method is " +
    "SupplyAirFlowRate.")]
[JsonProperty(PropertyName="no_load_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> NoLoadSupplyAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Enter the supply air volume flow rate per total floor area fraction. Required fie" +
    "ld when No Load Supply Air Flow Rate Method is FlowPerFloorArea.")]
[JsonProperty(PropertyName="no_load_supply_air_flow_rate_per_floor_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NoLoadSupplyAirFlowRatePerFloorArea { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedCoolingValue.")]
[JsonProperty(PropertyName="no_load_fraction_of_autosized_cooling_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NoLoadFractionOfAutosizedCoolingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating supply air flo" +
    "w rate. Required field when No Load Supply Air Flow Rate Method is FractionOfAut" +
    "osizedHeatingValue.")]
[JsonProperty(PropertyName="no_load_fraction_of_autosized_heating_supply_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NoLoadFractionOfAutosizedHeatingSupplyAirFlowRate { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the cooling capacity. Requ" +
    "ired field when No Load Supply Air Flow Rate Method is FlowPerCoolingCapacity.")]
[JsonProperty(PropertyName="no_load_supply_air_flow_rate_per_unit_of_capacity_during_cooling_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringCoolingOperation { get; set; } = null;
        

[Description("Enter the supply air volume flow rate as a fraction of the heating capacity. Requ" +
    "ired field when No Load Supply Air Flow Rate Method is FlowPerHeatingCapacity.")]
[JsonProperty(PropertyName="no_load_supply_air_flow_rate_per_unit_of_capacity_during_heating_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> NoLoadSupplyAirFlowRatePerUnitOfCapacityDuringHeatingOperation { get; set; } = null;
        

[Description("Enter the maximum supply air temperature leaving the heating coil. When Control T" +
    "ype = SingleZoneVAV, enter the maximum air temperature limit for reduced fan spe" +
    "ed.")]
[JsonProperty(PropertyName="maximum_supply_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
public System.Nullable<double> MaximumSupplyAirTemperature { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum outdoor dry-bulb temperature for supplemental heater operation." +
    "")]
[JsonProperty(PropertyName="maximum_outdoor_dry_bulb_temperature_for_supplemental_heater_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MaximumOutdoorDryBulbTemperatureForSupplementalHeaterOperation { get; set; } = Double.Parse("21", CultureInfo.InvariantCulture);
        

[Description("If this field is blank, outdoor temperature from the weather file is used. If thi" +
    "s field is not blank, the node name specified determines the outdoor temperature" +
    " used for controlling supplemental heater operation.")]
[JsonProperty(PropertyName="outdoor_dry_bulb_temperature_sensor_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string OutdoorDryBulbTemperatureSensorNodeName { get; set; } = "";
        

[Description("Used only for water source heat pump. The maximum on-off cycling rate for the com" +
    "pressor. Suggested value is 2.5 for a typical heat pump.")]
[JsonProperty(PropertyName="maximum_cycling_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MaximumCyclingRate { get; set; } = Double.Parse("2.5", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. Time constant for the cooling coil\'s capaci" +
    "ty to reach steady state after startup. Suggested value is 60 for a typical heat" +
    " pump.")]
[JsonProperty(PropertyName="heat_pump_time_constant", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatPumpTimeConstant { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. The fraction of on-cycle power use to adjus" +
    "t the part load fraction based on the off-cycle power consumption due to crankca" +
    "se heaters, controls, fans, and etc. Suggested value is 0.01 for a typical heat " +
    "pump.")]
[JsonProperty(PropertyName="fraction_of_on_cycle_power_use", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> FractionOfOnCyclePowerUse { get; set; } = Double.Parse("0.01", CultureInfo.InvariantCulture);
        

[Description("Used only for water source heat pump. Programmed time delay for heat pump fan to " +
    "shut off after compressor cycle off. Only required when fan operating mode is cy" +
    "cling. Enter 0 when fan operating mode is continuous.")]
[JsonProperty(PropertyName="heat_pump_fan_delay_time", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> HeatPumpFanDelayTime { get; set; } = Double.Parse("60", CultureInfo.InvariantCulture);
        

[Description("Enter the value of ancillary electric power for controls or other devices consume" +
    "d during the on cycle.")]
[JsonProperty(PropertyName="ancillary_on_cycle_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> AncillaryOnCycleElectricPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the value of ancillary electric power for controls or other devices consume" +
    "d during the off cycle.")]
[JsonProperty(PropertyName="ancillary_off_cycle_electric_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> AncillaryOffCycleElectricPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("If non-zero, then the heat recovery inlet and outlet node names must be entered. " +
    "Used for heat recovery to an EnergyPlus plant loop.")]
[JsonProperty(PropertyName="design_heat_recovery_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> DesignHeatRecoveryWaterFlowRate { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

[Description("Enter the maximum heat recovery inlet temperature allowed for heat recovery.")]
[JsonProperty(PropertyName="maximum_temperature_for_heat_recovery", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public System.Nullable<double> MaximumTemperatureForHeatRecovery { get; set; } = Double.Parse("80", CultureInfo.InvariantCulture);
        

[Description("Enter the name of the heat recovery water inlet node if plant water loop connecti" +
    "ons are present.")]
[JsonProperty(PropertyName="heat_recovery_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string HeatRecoveryWaterInletNodeName { get; set; } = "";
        

[Description("Enter the name of the heat recovery water outlet node if plant water loop connect" +
    "ions are present.")]
[JsonProperty(PropertyName="heat_recovery_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string HeatRecoveryWaterOutletNodeName { get; set; } = "";
        

[Description("Enter the type of performance specification object used to describe the multispee" +
    "d coil.")]
[JsonProperty(PropertyName="design_specification_multispeed_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
[Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
public AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType DesignSpecificationMultispeedObjectType { get; set; } = (AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType)Enum.Parse(typeof(AirLoopHVAC_UnitarySystem_DesignSpecificationMultispeedObjectType), "UnitarySystemPerformanceMultispeed");
        

[Description("Enter the name of the performance specification object used to describe the multi" +
    "speed coil.")]
[JsonProperty(PropertyName="design_specification_multispeed_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
public string DesignSpecificationMultispeedObjectName { get; set; } = "";
    }
}
