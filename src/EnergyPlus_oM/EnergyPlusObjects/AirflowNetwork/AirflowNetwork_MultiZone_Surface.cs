using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AirflowNetwork
{
    [Description("This object specifies the properties of a surface linkage through which air flows" +
                 ". Airflow Report: Node 1 as an inside face zone; Node 2 as an outside face zone " +
                 "or external node.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirflowNetwork_MultiZone_Surface : BHoMObject
    {
        

        [Description("Enter the name of a heat transfer surface.")]
        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [Description(@"Enter the name of an Airflow Network leakage component. A leakage component is one of the following AirflowNetwork:Multizone objects: AirflowNetwork:MultiZone:Component:DetailedOpening, AirflowNetwork:MultiZone:Component:SimpleOpening, AirflowNetwork:MultiZone:Surface:Crack, AirflowNetwork:MultiZone:Surface:EffectiveLeakageArea, AirflowNetwork:MultiZone:Component:HorizontalOpening, or AirflowNetwork:MultiZone:Component:ZoneExhaustFan. When the zone exhaust fan name is entered, any surface control fields below A3 are ignored when the zone exhaust fan turns on.")]
        [JsonProperty(PropertyName="leakage_component_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string LeakageComponentName { get; set; } = "";
        

        [Description("Used if Wind Pressure Coefficient Type = Input in the AirflowNetwork:SimulationCo" +
                     "ntrol object, otherwise this field may be left blank.")]
        [JsonProperty(PropertyName="external_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ExternalNodeName { get; set; } = "";
        

        [Description("This field specifies a multiplier for a crack, window, or door.")]
        [JsonProperty(PropertyName="window_door_opening_factor_or_crack_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> WindowDoorOpeningFactorOrCrackFactor { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description(@"When Ventilation Control Mode = Temperature or Enthalpy, the following fields are used to modulate the Ventilation Open Factor for a window or door opening according to the parent zone's indoor-outdoor temperature or enthalpy difference. When Ventilation Control Mode = AdjacentTemperature or AdjacentEnthalpy, the following fields are used to modulate the Ventilation Open Factor for an interior window or door opening according to temperature or enthalpy difference between the parent zone and the adjacent zone. Constant: controlled by field Venting Schedule Name. NoVent: control will not open window or door during simulation (Ventilation Open Factor = 0). ZoneLevel: control will be controlled by AirflowNetwork:MultiZone:Zone Mode.")]
        [JsonProperty(PropertyName="ventilation_control_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_MultiZone_Surface_VentilationControlMode VentilationControlMode { get; set; } = (AirflowNetwork_MultiZone_Surface_VentilationControlMode)Enum.Parse(typeof(AirflowNetwork_MultiZone_Surface_VentilationControlMode), "ZoneLevel");
        

        [Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
        [JsonProperty(PropertyName="ventilation_control_zone_temperature_setpoint_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VentilationControlZoneTemperatureSetpointScheduleName { get; set; } = "";
        

        [Description("Used only if Ventilation Control Mode = Temperature or Enthalpy.")]
        [JsonProperty(PropertyName="minimum_venting_open_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumVentingOpenFactor { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description("Applicable only if Ventilation Control Mode = Temperature")]
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
        

        [Description(@"Non-zero schedule value means venting is allowed if other venting control conditions are satisfied. A zero (or negative) schedule value means venting is not allowed under any circumstances. The schedule values should be greater than or equal to 0 and less than or equal to 1. If this schedule is not specified then venting is allowed if other venting control conditions are satisfied. Not used if Ventilation Control Mode = NoVent or ZoneLevel.")]
        [JsonProperty(PropertyName="venting_availability_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string VentingAvailabilityScheduleName { get; set; } = "";
        

        [Description("Enter the name where Occupancy Ventilation Control is required.")]
        [JsonProperty(PropertyName="occupant_ventilation_control_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OccupantVentilationControlName { get; set; } = "";
        

        [Description("This field is applied to a non-rectangular window or door. The equivalent shape h" +
                     "as the same area as a polygonal window or door.")]
        [JsonProperty(PropertyName="equivalent_rectangle_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod EquivalentRectangleMethod { get; set; } = (AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod)Enum.Parse(typeof(AirflowNetwork_MultiZone_Surface_EquivalentRectangleMethod), "PolygonHeight");
        

        [Description("This field is used when UserDefinedAspectRatio is entered in the Equivalent Recta" +
                     "ngle Method field.")]
        [JsonProperty(PropertyName="equivalent_rectangle_aspect_ratio", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EquivalentRectangleAspectRatio { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
    }
}