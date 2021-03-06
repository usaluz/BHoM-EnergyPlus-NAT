using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Used to describe a custom model equation for surface convection heat transfer coe" +
                 "fficient If more than one curve is referenced they are all used and added togeth" +
                 "er.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceConvectionAlgorithm_Inside_UserCurve : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Controls which temperature is differenced from surface temperature when using the" +
                     " Hc value")]
        [JsonProperty(PropertyName="reference_temperature_for_convection_heat_transfer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer ReferenceTemperatureForConvectionHeatTransfer { get; set; } = (SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_UserCurve_ReferenceTemperatureForConvectionHeatTransfer), "AdjacentAirTemperature");
        

        [Description("Curve\'s \"x\" is absolute value of delta-T (Surface temperature minus reference tem" +
                     "perature, (C))")]
        [JsonProperty(PropertyName="hc_function_of_temperature_difference_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HcFunctionOfTemperatureDifferenceCurveName { get; set; } = "";
        

        [Description("Curve\'s \"x\" is absolute value of delta-T/Height (Surface temp minus Air temp)/(ve" +
                     "rtical length scale), (C/m) when used for an inside face the vertical length sca" +
                     "le is the zone\'s interior height")]
        [JsonProperty(PropertyName="hc_function_of_temperature_difference_divided_by_height_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HcFunctionOfTemperatureDifferenceDividedByHeightCurveName { get; set; } = "";
        

        [Description("Curve\'s \"x\" is mechanical ACH (Air Changes per hour from mechanical air system), " +
                     "(1/hr)")]
        [JsonProperty(PropertyName="hc_function_of_air_change_rate_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HcFunctionOfAirChangeRateCurveName { get; set; } = "";
        

        [Description("Curve\'s \"x\" is mechanical system air flow rate (m3/s) divided by zone\'s length al" +
                     "ong exterior walls (m).")]
        [JsonProperty(PropertyName="hc_function_of_air_system_volume_flow_rate_divided_by_zone_perimeter_length_curve" +
                                   "_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string HcFunctionOfAirSystemVolumeFlowRateDividedByZonePerimeterLengthCurveName { get; set; } = "";
    }
}