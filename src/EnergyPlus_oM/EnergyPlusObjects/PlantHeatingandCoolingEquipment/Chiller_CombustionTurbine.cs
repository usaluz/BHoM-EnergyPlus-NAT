using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantHeatingandCoolingEquipment
{
    [Description("This chiller model is the empirical model from the Building Loads and System Ther" +
                 "modynamics (BLAST) program. Chiller performance curves are generated by fitting " +
                 "catalog data to third order polynomial equations. Three sets of coefficients are" +
                 " required.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Chiller_CombustionTurbine : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_CondenserType CondenserType { get; set; } = (Chiller_CombustionTurbine_CondenserType)Enum.Parse(typeof(Chiller_CombustionTurbine_CondenserType), "AirCooled");
        

        [JsonProperty(PropertyName="nominal_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> NominalCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="nominal_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NominalCop { get; set; } = null;
        

        [JsonProperty(PropertyName="chilled_water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="chilled_water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChilledWaterOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="condenser_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CondenserOutletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="minimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="maximum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="optimum_part_load_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OptimumPartLoadRatio { get; set; } = null;
        

        [JsonProperty(PropertyName="design_condenser_inlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignCondenserInletTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="temperature_rise_coefficient", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TemperatureRiseCoefficient { get; set; } = null;
        

        [JsonProperty(PropertyName="design_chilled_water_outlet_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignChilledWaterOutletTemperature { get; set; } = null;
        

        [Description("For variable volume this is the max flow & for constant flow this is the flow.")]
        [JsonProperty(PropertyName="design_chilled_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignChilledWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is not used for Condenser Type = AirCooled or EvaporativelyCooled")]
        [JsonProperty(PropertyName="design_condenser_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignCondenserWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="coefficient_1_of_capacity_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_capacity_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_capacity_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfCapacityRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_power_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_power_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_power_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfPowerRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_full_load_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfFullLoadRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_full_load_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfFullLoadRatioCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_full_load_ratio_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfFullLoadRatioCurve { get; set; } = null;
        

        [Description("Special Gas Turbine Chiller Parameters Below")]
        [JsonProperty(PropertyName="chilled_water_outlet_temperature_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChilledWaterOutletTemperatureLowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_temperature_based_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_temperature_based_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_temperature_based_fuel_input_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfTemperatureBasedFuelInputCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_exhaust_flow_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_exhaust_flow_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_exhaust_flow_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfExhaustFlowCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_temperature_based_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_temperature_based_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_temperature_based_exhaust_gas_temperature_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfTemperatureBasedExhaustGasTemperatureCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_recovery_lube_heat_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_2_of_recovery_lube_heat_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_3_of_recovery_lube_heat_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient3OfRecoveryLubeHeatCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="coefficient_1_of_u_factor_times_area_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient1OfUFactorTimesAreaCurve { get; set; } = null;
        

        [Description("typical value .9")]
        [JsonProperty(PropertyName="coefficient_2_of_u_factor_times_area_curve", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> Coefficient2OfUFactorTimesAreaCurve { get; set; } = null;
        

        [JsonProperty(PropertyName="gas_turbine_engine_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GasTurbineEngineCapacity { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="maximum_exhaust_flow_per_unit_of_power_output", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumExhaustFlowPerUnitOfPowerOutput { get; set; } = null;
        

        [JsonProperty(PropertyName="design_steam_saturation_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignSteamSaturationTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="fuel_higher_heating_value", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FuelHigherHeatingValue { get; set; } = null;
        

        [Description("If non-zero, then the heat recovery inlet and outlet node names must be entered.")]
        [JsonProperty(PropertyName="design_heat_recovery_water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> DesignHeatRecoveryWaterFlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="heat_recovery_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryInletNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="heat_recovery_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatRecoveryOutletNodeName { get; set; } = "";
        

        [Description(@"Select operating mode for fluid flow through the chiller. ""NotModulated"" is for either variable or constant pumping with flow controlled by the external plant system. ""ConstantFlow"" is for constant pumping with flow controlled by chiller to operate at full design flow rate. ""LeavingSetpointModulated"" is for variable pumping with flow controlled by chiller to vary flow to target a leaving temperature setpoint.")]
        [JsonProperty(PropertyName="chiller_flow_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_ChillerFlowMode ChillerFlowMode { get; set; } = (Chiller_CombustionTurbine_ChillerFlowMode)Enum.Parse(typeof(Chiller_CombustionTurbine_ChillerFlowMode), "NotModulated");
        

        [JsonProperty(PropertyName="fuel_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Chiller_CombustionTurbine_FuelType FuelType { get; set; } = (Chiller_CombustionTurbine_FuelType)Enum.Parse(typeof(Chiller_CombustionTurbine_FuelType), "NaturalGas");
        

        [JsonProperty(PropertyName="heat_recovery_maximum_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> HeatRecoveryMaximumTemperature { get; set; } = Double.Parse("80", CultureInfo.InvariantCulture);
        

        [Description("Multiplies the autosized capacity and flow rates")]
        [JsonProperty(PropertyName="sizing_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SizingFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled and for periods when the basin heater is available (field Basin Heater Operating Schedule Name). For this situation, The heater maintains the basin water temperature at the basin heater setpoint temperature when the outdoor air temperature falls below the setpoint temperature. The basin heater only operates when the chiller is not operating.")]
        [JsonProperty(PropertyName="basin_heater_capacity", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterCapacity { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("This field is only used for Condenser Type = EvaporativelyCooled. Enter the outdo" +
                     "or dry-bulb temperature when the basin heater turns on.")]
        [JsonProperty(PropertyName="basin_heater_setpoint_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasinHeaterSetpointTemperature { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
        

        [Description(@"This field is only used for Condenser Type = EvaporativelyCooled. Schedule values greater than 0 allow the basin heater to operate whenever the outdoor air dry-bulb temperature is below the basin heater setpoint temperature. If a schedule name is not entered, the basin heater is allowed to operate throughout the entire simulation.")]
        [JsonProperty(PropertyName="basin_heater_operating_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BasinHeaterOperatingScheduleName { get; set; } = "";
        

        [Description("This optional field is the fraction of total rejected heat that can be recovered " +
                     "at full load. Also used to autosize Design Heat Recovery Water Flow Rate as a fr" +
                     "action of Design Condenser Water Flow Rate.")]
        [JsonProperty(PropertyName="condenser_heat_recovery_relative_capacity_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserHeatRecoveryRelativeCapacityFraction { get; set; } = null;
        

        [Description("This optional field is the nominal turbine engine efficiency and is used when Gas" +
                     " Turbine Engine Capacity is set to Autosize")]
        [JsonProperty(PropertyName="turbine_engine_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> TurbineEngineEfficiency { get; set; } = Double.Parse("0.35", CultureInfo.InvariantCulture);
    }
}