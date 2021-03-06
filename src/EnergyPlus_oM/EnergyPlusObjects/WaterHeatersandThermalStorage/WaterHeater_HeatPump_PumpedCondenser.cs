using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.WaterHeatersandThermalStorage
{
    [Description(@"This object models an air-source heat pump for water heating where the water is pumped out of the tank, through a heating coil and returned to the tank. For wrapped condenser HPWHs, see WaterHeater:HeatPump:WrappedCondenser. WaterHeater:HeatPump:PumpedCondenser is a compound object that references other component objects - Coil:WaterHeating:AirToWaterHeatPump:*, Fan:OnOff, WaterHeater:Mixed or WaterHeater:Stratified")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class WaterHeater_HeatPump_PumpedCondenser : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the heat pump compressor is off and the parasitic electric energy is also off.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description("Defines the cut-out temperature where the heat pump compressor turns off. The hea" +
                     "t pump compressor setpoint temperature should always be greater than the water t" +
                     "ank\'s heater (element or burner) setpoint temperature.")]
        [JsonProperty(PropertyName="compressor_setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompressorSetpointTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the heat pump compressor turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the heat pump compressor cut-in temperature.")]
        [JsonProperty(PropertyName="dead_band_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeadBandTemperatureDifference { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Should match the field Source Outlet Node Name in the water heater tank object. S" +
                     "hould also match the Condenser Water Inlet Node Name in the associated DX coil o" +
                     "bject.")]
        [JsonProperty(PropertyName="condenser_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserWaterInletNodeName { get; set; } = "";
        

        [Description("Should match the field Source Inlet Node Name in water heater tank object. Should" +
                     " also match the Condenser Water Outlet Node Name in the associated DX Coil objec" +
                     "t.")]
        [JsonProperty(PropertyName="condenser_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserWaterOutletNodeName { get; set; } = "";
        

        [Description("Actual water flow rate through the heat pump\'s water coil (condenser). If autocal" +
                     "culated, the water flow rate is set equal to 4.487E-8 m3/s/W times the rated hea" +
                     "ting capacity of the heat pump\'s DX coil.")]
        [JsonProperty(PropertyName="condenser_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> CondenserWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Actual air flow rate across the heat pump\'s air coil (evaporator). If autocalcula" +
                     "ted, the air flow rate is set equal to 5.035E-5 m3/s/W times the rated heating c" +
                     "apacity of the heat pump\'s DX coil.")]
        [JsonProperty(PropertyName="evaporator_air_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutocalculateJsonConverter))]
        public System.Nullable<double> EvaporatorAirFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Defines the configuration of the airflow path through the air coil and fan sectio" +
                     "n.")]
        [JsonProperty(PropertyName="inlet_air_configuration", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration InletAirConfiguration { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_InletAirConfiguration), "OutdoorAirOnly");
        

        [Description("Zone air exhaust node name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOu" +
                     "tdoorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Othe" +
                     "rwise, leave field blank.")]
        [JsonProperty(PropertyName="air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirInletNodeName { get; set; } = "";
        

        [Description("Zone Air Inlet Node Name if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutd" +
                     "oorAir. Simply a unique Node Name if Inlet Air Configuration is Schedule. Otherw" +
                     "ise, leave field blank.")]
        [JsonProperty(PropertyName="air_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AirOutletNodeName { get; set; } = "";
        

        [Description("Outdoor air node name if inlet air configuration is ZoneAndOutdoorAir or OutdoorA" +
                     "irOnly, otherwise leave field blank.")]
        [JsonProperty(PropertyName="outdoor_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutdoorAirNodeName { get; set; } = "";
        

        [Description("Simply a unique Node Name if Inlet Air Configuration is ZoneAndOutdoorAir or Outd" +
                     "oorAirOnly, otherwise leave field blank.")]
        [JsonProperty(PropertyName="exhaust_air_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExhaustAirNodeName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
                     " values should be degrees C.")]
        [JsonProperty(PropertyName="inlet_air_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletAirTemperatureScheduleName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is Schedule, otherwise leave blank. Schedule" +
                     " values are entered as a fraction (e.g. 0.5 is equal to 50%RH)")]
        [JsonProperty(PropertyName="inlet_air_humidity_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletAirHumidityScheduleName { get; set; } = "";
        

        [Description("Used only if Inlet Air Configuration is ZoneAirOnly or ZoneAndOutdoorAir. Otherwi" +
                     "se, leave field blank.")]
        [JsonProperty(PropertyName="inlet_air_zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletAirZoneName { get; set; } = "";
        

        [Description("Specify the type of water heater tank used by this heat pump water heater.")]
        [JsonProperty(PropertyName="tank_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_TankObjectType TankObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_TankObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_TankObjectType), "Empty");
        

        [Description("Needs to match the name used in the corresponding Water Heater object.")]
        [JsonProperty(PropertyName="tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TankName { get; set; } = "";
        

        [Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
                     " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
                     "ect when connected to a plant loop.")]
        [JsonProperty(PropertyName="tank_use_side_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TankUseSideInletNodeName { get; set; } = "";
        

        [Description("Used only when the heat pump water heater is connected to a plant loop, otherwise" +
                     " leave blank. Needs to match the name used in the corresponding Water Heater obj" +
                     "ect when connected to a plant loop.")]
        [JsonProperty(PropertyName="tank_use_side_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TankUseSideOutletNodeName { get; set; } = "";
        

        [Description("Specify the type of DX coil used by this heat pump water heater. The only valid c" +
                     "hoice is Coil:WaterHeating:AirToWaterHeatPump:Pumped and Coil:WaterHeating:AirTo" +
                     "WaterHeatPump:VariableSpeed, and CoilSystem:IntegratedHeatPump:AirSource")]
        [JsonProperty(PropertyName="dx_coil_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType DxCoilObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_DxCoilObjectType), "Empty");
        

        [Description("Must match the name used in the corresponding Coil:WaterHeating:AirToWaterHeatPum" +
                     "p:* object, or CoilSystem:IntegratedHeatPump:AirSource")]
        [JsonProperty(PropertyName="dx_coil_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DxCoilName { get; set; } = "";
        

        [Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
                     "below this value.")]
        [JsonProperty(PropertyName="minimum_inlet_air_temperature_for_compressor_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumInletAirTemperatureForCompressorOperation { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Heat pump compressor will not operate when the inlet air dry-bulb temperature is " +
                     "above this value.")]
        [JsonProperty(PropertyName="maximum_inlet_air_temperature_for_compressor_operation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumInletAirTemperatureForCompressorOperation { get; set; } = Double.Parse("48.88888888889", CultureInfo.InvariantCulture);
        

        [Description("If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneAndOutdoo" +
                     "rAir. If Schedule is selected, then you must provide a Compressor Ambient Temper" +
                     "ature Schedule Name below.")]
        [JsonProperty(PropertyName="compressor_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_CompressorLocation CompressorLocation { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_CompressorLocation)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_CompressorLocation), "Outdoors");
        

        [Description("Used only if Compressor Location is Schedule, otherwise leave field blank.")]
        [JsonProperty(PropertyName="compressor_ambient_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CompressorAmbientTemperatureScheduleName { get; set; } = "";
        

        [Description("Specify the type of fan used by this heat pump water heater. The only valid choic" +
                     "es are Fan:SystemModel or Fan:OnOff.")]
        [JsonProperty(PropertyName="fan_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_FanObjectType FanObjectType { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_FanObjectType)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_FanObjectType), "Empty");
        

        [Description("Needs to match the name used in the corresponding Fan:SystemModel or Fan:OnOff ob" +
                     "ject.")]
        [JsonProperty(PropertyName="fan_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FanName { get; set; } = "";
        

        [Description("BlowThrough means the fan is located before the air coil (upstream). DrawThrough " +
                     "means the fan is located after the air coil (downstream).")]
        [JsonProperty(PropertyName="fan_placement", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_FanPlacement FanPlacement { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_FanPlacement)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_FanPlacement), "DrawThrough");
        

        [Description("Parasitic electric power consumed when the heat pump compressor operates. Does no" +
                     "t contribute to water heating but can impact the zone air heat balance.")]
        [JsonProperty(PropertyName="on_cycle_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OnCycleParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Parasitic electric power consumed when the heat pump compressor is off. Does not " +
                     "contribute to water heating but can impact the zone air heat balance. Off-cycle " +
                     "parasitic power is 0 when the availability schedule is 0.")]
        [JsonProperty(PropertyName="off_cycle_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field determines if the parasitic electric load impacts the zone air heat ba" +
                     "lance. If Zone is selected, Inlet Air Configuration must be ZoneAirOnly or ZoneA" +
                     "ndOutdoorAir.")]
        [JsonProperty(PropertyName="parasitic_heat_rejection_location", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation ParasiticHeatRejectionLocation { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_ParasiticHeatRejectionLocation), "Outdoors");
        

        [Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
                     "eld blank.")]
        [JsonProperty(PropertyName="inlet_air_mixer_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletAirMixerNodeName { get; set; } = "";
        

        [Description("Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave fi" +
                     "eld blank.")]
        [JsonProperty(PropertyName="outlet_air_splitter_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutletAirSplitterNodeName { get; set; } = "";
        

        [Description(@"Required only if Inlet Air Configuration is ZoneAndOutdoorAir, otherwise leave field blank. Schedule values define whether the heat pump draws its inlet air from the zone, outdoors or a combination of zone and outdoor air. A schedule value of 0 denotes inlet air is drawn only from the zone. A schedule value of 1 denotes inlet air is drawn only from outdoors. Schedule values between 0 and 1 denote a mixture of zone and outdoor air proportional to the schedule value (i.e. 0.4 = 40% outdoor air, 60% zone air).")]
        [JsonProperty(PropertyName="inlet_air_mixer_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InletAirMixerScheduleName { get; set; } = "";
        

        [Description(@"MutuallyExclusive means that once the tank heating element is active the heat pump is shut down until setpoint is reached. Simultaneous (default) means that both the tank heating element and heat pump are used at the same time recover the tank temperature.")]
        [JsonProperty(PropertyName="tank_element_control_logic", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic TankElementControlLogic { get; set; } = (WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic)Enum.Parse(typeof(WaterHeater_HeatPump_PumpedCondenser_TankElementControlLogic), "Simultaneous");
        

        [Description("Used to indicate height of control sensor for Tank Object Type = WaterHeater:Stra" +
                     "tified If left blank, it will default to the height of Heater1")]
        [JsonProperty(PropertyName="control_sensor_1_height_in_stratified_tank", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlSensor1HeightInStratifiedTank { get; set; } = null;
        

        [Description("Weight to give Control Sensor 1 temperature The weight of Control Sensor 2 will b" +
                     "e 1 - (wt. of control sensor 1)")]
        [JsonProperty(PropertyName="control_sensor_1_weight", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlSensor1Weight { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Used to indicate height of control sensor for Tank Object Type = WaterHeater:Stra" +
                     "tified If left blank, it will default to the height of Heater2")]
        [JsonProperty(PropertyName="control_sensor_2_height_in_stratified_tank", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ControlSensor2HeightInStratifiedTank { get; set; } = null;
    }
}