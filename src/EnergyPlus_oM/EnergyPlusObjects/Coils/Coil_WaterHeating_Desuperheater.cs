using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Coils
{
    [Description(@"Desuperheater air heating coil. The heating energy provided by this coil is reclaimed from the superheated refrigerant gas leaving a compressor and does not impact the performance of the compressor. This coil must be used with a water heater tank, see Water Heater:Mixed.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Coil_WaterHeating_Desuperheater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description(@"Availability schedule name for this system. Schedule value > 0 means the system is available. If this field is blank, the system is always available. Schedule values of 0 denote the desuperheater heating coil is off and the parasitic electric energy is also off.")]
        [JsonProperty(PropertyName="availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AvailabilityScheduleName { get; set; } = "";
        

        [Description(@"Defines the cut-out temperature where the desuperheater water heating coil turns off. The desuperheater heating coil setpoint temperature should always be greater than the water tank's heater (element or burner) setpoint temperature. Temperature schedule values should be in degrees C.")]
        [JsonProperty(PropertyName="setpoint_temperature_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SetpointTemperatureScheduleName { get; set; } = "";
        

        [Description(@"Setpoint temperature minus the dead band temperature difference defines the cut-in temperature where the desuperheater water heating coil turns on. The water tank's heater (element or burner) setpoint temperature should always be less than the desuperheater heating coil cut-in temperature.")]
        [JsonProperty(PropertyName="dead_band_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DeadBandTemperatureDifference { get; set; } = Double.Parse("5", CultureInfo.InvariantCulture);
        

        [Description("Enter the fraction of waste heat reclaimed by the desuperheater water heating coi" +
                     "l.")]
        [JsonProperty(PropertyName="rated_heat_reclaim_recovery_efficiency", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedHeatReclaimRecoveryEfficiency { get; set; } = null;
        

        [Description("The inlet water temperature corresponding to the rated heat reclaim recovery effi" +
                     "ciency.")]
        [JsonProperty(PropertyName="rated_inlet_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedInletWaterTemperature { get; set; } = null;
        

        [Description("The outdoor air dry-bulb temperature corresponding to the rated heat reclaim reco" +
                     "very efficiency.")]
        [JsonProperty(PropertyName="rated_outdoor_air_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RatedOutdoorAirTemperature { get; set; } = null;
        

        [Description("The desuperheater water heating coil is off when the inlet water temperature is a" +
                     "bove the maximum inlet water temperature for heat reclaim.")]
        [JsonProperty(PropertyName="maximum_inlet_water_temperature_for_heat_reclaim", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumInletWaterTemperatureForHeatReclaim { get; set; } = null;
        

        [Description(@"A biquadratic curve defining the performance of the desuperheater heating coil. Performance can be specified as a function of inlet water temperature, outdoor air dry-bulb temperature, or both. Curve = a + b*Tw + c*Tw**2 + d*odb + e*odb**2 + f*Tw*odb. Tw = desuperheater heating coil entering water temperature (C). Odb = outdoor dry-bulb temperature at DX system condenser (C).")]
        [JsonProperty(PropertyName="heat_reclaim_efficiency_function_of_temperature_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatReclaimEfficiencyFunctionOfTemperatureCurveName { get; set; } = "";
        

        [Description("The node from which the desuperheater heating coil draws its inlet water. This na" +
                     "me should match the source side outlet node name in the associated water heater " +
                     "tank object.")]
        [JsonProperty(PropertyName="water_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterInletNodeName { get; set; } = "";
        

        [Description("The node to which the desuperheater heating coil sends its outlet water. This nam" +
                     "e should match the source side inlet node name in the associated water heater ta" +
                     "nk object.")]
        [JsonProperty(PropertyName="water_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WaterOutletNodeName { get; set; } = "";
        

        [Description("Specify the type of water heater tank used by this desuperheater water heating co" +
                     "il.")]
        [JsonProperty(PropertyName="tank_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_WaterHeating_Desuperheater_TankObjectType TankObjectType { get; set; } = (Coil_WaterHeating_Desuperheater_TankObjectType)Enum.Parse(typeof(Coil_WaterHeating_Desuperheater_TankObjectType), "Empty");
        

        [Description("The name of the water heater tank used by this desuperheater water heating coil. " +
                     "Needs to match the name used in the corresponding water heater object.")]
        [JsonProperty(PropertyName="tank_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TankName { get; set; } = "";
        

        [Description("The type of DX system that is providing waste heat for reclaim.")]
        [JsonProperty(PropertyName="heating_source_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Coil_WaterHeating_Desuperheater_HeatingSourceObjectType HeatingSourceObjectType { get; set; } = (Coil_WaterHeating_Desuperheater_HeatingSourceObjectType)Enum.Parse(typeof(Coil_WaterHeating_Desuperheater_HeatingSourceObjectType), "CoilCoolingDXMultiSpeed");
        

        [Description("The name of the DX system used for heat reclaim.")]
        [JsonProperty(PropertyName="heating_source_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HeatingSourceName { get; set; } = "";
        

        [Description("The operating water flow rate.")]
        [JsonProperty(PropertyName="water_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterFlowRate { get; set; } = null;
        

        [Description("The water circulation pump electric power.")]
        [JsonProperty(PropertyName="water_pump_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WaterPumpPower { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("The fraction of pump heat transferred to the water. The pump is assumed to be dow" +
                     "nstream of the desuperheater water heating coil.")]
        [JsonProperty(PropertyName="fraction_of_pump_heat_to_water", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FractionOfPumpHeatToWater { get; set; } = Double.Parse("0.2", CultureInfo.InvariantCulture);
        

        [Description("Parasitic electric power consumed when the desuperheater water heating coil opera" +
                     "tes. Parasitic electric load does not contribute to water heating or the zone ai" +
                     "r heat balance.")]
        [JsonProperty(PropertyName="on_cycle_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OnCycleParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Parasitic electric load consumed when the desuperheater water heating coil is off" +
                     ". Parasitic electric load does not contribute to water heating or the zone air h" +
                     "eat balance. Off-cycle parasitic power is 0 when the availability schedule is 0." +
                     "")]
        [JsonProperty(PropertyName="off_cycle_parasitic_electric_load", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> OffCycleParasiticElectricLoad { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
    }
}