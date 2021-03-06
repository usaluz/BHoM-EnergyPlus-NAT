using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object is used to simultaneously control a thermal zone\'s window and door op" +
                 "enings, both exterior and interior.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Zone : BHoMObject
    {
        

        [Description("Enter the zone name where ventilation control is required.")]
        [JsonProperty(PropertyName="zone_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZoneName { get; set; } = "";
        

        [Description(@"When Ventilation Control Mode = Temperature or Enthalpy, the following fields are used to modulate the Ventilation Open Factor for all window and door openings in the zone according to the zone's indoor-outdoor temperature or enthalpy difference. Constant: controlled by field Venting Schedule Name. NoVent: control will not open window or door during simulation (Ventilation Open Factor = 0).")]
        [JsonProperty(PropertyName="ventilation_control_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_MultiZone_Zone_VentilationControlMode VentilationControlMode { get; set; } = (AirflowNetwork_MultiZone_Zone_VentilationControlMode)Enum.Parse(typeof(AirflowNetwork_MultiZone_Zone_VentilationControlMode), "NoVent");
        

        [Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
        [JsonProperty(PropertyName="ventilation_control_zone_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
        [JsonProperty(PropertyName="minimum_venting_open_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumVentingOpenFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Ventilation Control Mode = Temperature. This value must be les" +
                     "s than the corresponding upper value (next field).")]
        [JsonProperty(PropertyName="indoor_and_outdoor_temperature_difference_lower_limit_for_maximum_venting_open_fa" +
                                   "ctor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorAndOutdoorTemperatureDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Ventilation Control Mode = Temperature. This value must be gre" +
                     "ater than the corresponding lower value (previous field).")]
        [JsonProperty(PropertyName="indoor_and_outdoor_temperature_difference_upper_limit_for_minimum_venting_open_fa" +
                                   "ctor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorAndOutdoorTemperatureDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = Double.Parse("100", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be less t" +
                     "han the corresponding upper value (next field).")]
        [JsonProperty(PropertyName="indoor_and_outdoor_enthalpy_difference_lower_limit_for_maximum_venting_open_facto" +
                                   "r", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorAndOutdoorEnthalpyDifferenceLowerLimitForMaximumVentingOpenFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Ventilation Control Mode = Enthalpy. This value must be greate" +
                     "r than the corresponding lower value (previous field).")]
        [JsonProperty(PropertyName="indoor_and_outdoor_enthalpy_difference_upper_limit_for_minimum_venting_open_facto" +
                                   "r", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> IndoorAndOutdoorEnthalpyDifferenceUpperLimitForMinimumVentingOpenFactor { get; set; } = Double.Parse("300000", CultureInfo.InvariantCulture);
        

        [Description(@"Non-zero Schedule value means venting is allowed if other venting control conditions are satisfied. A zero (or negative) Schedule value means venting is not allowed under any The Schedule values should be greater than or equal to 0 and less than or equal to 1. circumstances. If this Schedule is not specified then venting is allowed if other venting control conditions are satisfied. Not used if Ventilation Control Mode = NoVent.")]
        [JsonProperty(PropertyName="venting_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VentingAvailabilityScheduleName { get; set; } = "";
        

        [Description(@"Selecting Advanced results in EnergyPlus calculating modified Wind Pressure Coefficients to account for wind direction and turbulence effects on single sided ventilation rates. Model is only valid for zones with 2 openings, both of which are on a single facade.")]
        [JsonProperty(PropertyName="single_sided_wind_pressure_coefficient_algorithm", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm SingleSidedWindPressureCoefficientAlgorithm { get; set; } = (AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm)Enum.Parse(typeof(AirflowNetwork_MultiZone_Zone_SingleSidedWindPressureCoefficientAlgorithm), "Standard");
        

        [Description("This is the whole building width along the direction of the facade of this zone.")]
        [JsonProperty(PropertyName="facade_width", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> FacadeWidth { get; set; } = Double.Parse("10", CultureInfo.InvariantCulture);
        

        [Description("Enter the name where Occupancy Ventilation Control is required.")]
        [JsonProperty(PropertyName="occupant_ventilation_control_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OccupantVentilationControlName { get; set; } = "";
    }
}