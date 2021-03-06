using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description("DX cooling coil performance for a single speed within a single operating mode.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_Cooling_DX_CurveFit_Speed : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Ratio of capacity at this speed to the operating mode Rated Gross Total Cooling C" +
                     "apacity")]
        [JsonProperty(PropertyName="gross_total_cooling_capacity_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GrossTotalCoolingCapacityFraction { get; set; } = null;
        

        [Description("Ratio of capacity at this speed to the operating mode Rated Evaporator Air Flow R" +
                     "ate")]
        [JsonProperty(PropertyName="evaporator_air_flow_rate_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporatorAirFlowRateFraction { get; set; } = null;
        

        [Description("Ratio of condenser air flow at this speed to the operating mode Rated Condenser A" +
                     "ir Flow Rate")]
        [JsonProperty(PropertyName="condenser_air_flow_rate_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> CondenserAirFlowRateFraction { get; set; } = null;
        

        [Description("Rated sensible heat ratio (gross sensible capacity/gross total capacity) sensible" +
                     " and total capacities do not include supply fan heat")]
        [JsonProperty(PropertyName="gross_sensible_heat_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> GrossSensibleHeatRatio { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("Gross cooling capacity divided by power input to the compressor and condenser fan" +
                     ". Does not include supply fan heat or supply fan electrical energy input.")]
        [JsonProperty(PropertyName="gross_cooling_cop", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GrossCoolingCop { get; set; } = Double.Parse("3", CultureInfo.InvariantCulture);
        

        [Description("The fraction of the cooling coil face which is actively cooled at this speed. For" +
                     " non-split-face coils, this should be 1.0.")]
        [JsonProperty(PropertyName="active_fraction_of_coil_face_area", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ActiveFractionOfCoilFaceArea { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"Enter the evaporator fan power per air volume flow rate at the rated test conditions. The test conditions vary external static pressure based on total cooling capacity. This value is only used to calculate Seasonal Energy Efficiency Ratio (SEER), and the Standard Rating (Net) Cooling Capacity which will be outputs in the EnergyPlus eio file. This value is not used for modeling the evaporator fan during simulations.")]
        [JsonProperty(PropertyName="rated_evaporator_fan_power_per_volume_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedEvaporatorFanPowerPerVolumeFlowRate { get; set; } = Double.Parse("773.3", CultureInfo.InvariantCulture);
        

        [Description("Ratio of evaporative condenser pump power at this speed to the operating mode Nom" +
                     "inal Evaporative Condenser Pump Power")]
        [JsonProperty(PropertyName="evaporative_condenser_pump_power_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserPumpPowerFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="evaporative_condenser_effectiveness", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EvaporativeCondenserEffectiveness { get; set; } = Double.Parse("0.9", CultureInfo.InvariantCulture);
        

        [Description("biquadratic curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb quadratic cu" +
                     "rve = a + b*edb + c*edb**2 wb = entering wet-bulb temperature (C) edb = dry-bulb" +
                     " temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="total_cooling_capacity_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TotalCoolingCapacityModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load flow")]
        [JsonProperty(PropertyName="total_cooling_capacity_modifier_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TotalCoolingCapacityModifierFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("curve = a + b*wb + c*wb**2 + d*edb + e*edb**2 + f*wb*edb wb = entering wet-bulb t" +
                     "emperature (C) edb = dry-bulb temperature seen by the condenser (C)")]
        [JsonProperty(PropertyName="energy_input_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnergyInputRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 f" +
                     "f = Fraction of the full load flow")]
        [JsonProperty(PropertyName="energy_input_ratio_modifier_function_of_air_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string EnergyInputRatioModifierFunctionOfAirFlowFractionCurveName { get; set; } = "";
        

        [Description("quadratic curve = a + b*PLR + c*PLR**2 cubic curve = a + b*PLR + c*PLR**2 + d*PLR" +
                     "**3 PLR = part load ratio (cooling load/steady state capacity)")]
        [JsonProperty(PropertyName="part_load_fraction_correlation_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PartLoadFractionCorrelationCurveName { get; set; } = "";
        

        [Description("Recoverable waste heat at full load and rated conditions")]
        [JsonProperty(PropertyName="rated_waste_heat_fraction_of_power_input", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedWasteHeatFractionOfPowerInput { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("curve = a + b*cdb + c*cdb**2 + d*edb + e*edb**2 + f*cdb*edb cdb = entering conden" +
                     "ser dry-bulb temperature (C) edb = entering coil dry-bulb temperature (C)")]
        [JsonProperty(PropertyName="waste_heat_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WasteHeatModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"curve = a + b*wb + c*wb**2 + d*db + e*db**2 + f*wb*db wb = entering wet-bulb temperature seen by the DX cooling coil (C) db = entering dry-bulb temperature seen by the DX cooling coil (C) entering temperature can be outside air or pretreated air. If this curve is used and the Sensible Heat Ratio Modifier Function of Flow Fraction (SHRFFF) Curve Name is blank, the SHRFFF is assumed to be a constant value of 1.0.")]
        [JsonProperty(PropertyName="sensible_heat_ratio_modifier_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SensibleHeatRatioModifierFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description(@"quadratic curve = a + b*ff + c*ff**2 cubic curve = a + b*ff + c*ff**2 + d*ff**3 ff = fraction of the full load flow If this curve is used and the Sensible Heat Ratio Modifier Function of Temperature Curve Name (SHRFT) Curve Name is blank, the SHRFT is assumed to be a constant value of 1.0.")]
        [JsonProperty(PropertyName="sensible_heat_ratio_modifier_function_of_flow_fraction_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SensibleHeatRatioModifierFunctionOfFlowFractionCurveName { get; set; } = "";
    }
}