using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description(@"Options to change the individual convection model equations for dynamic selection when using AdaptiveConvectiongAlgorithm This object is only needed to make changes to the default model selections for any or all of the surface categories. This object is for the inside face, the side of the surface facing a thermal zone.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for vertical walls")]
        [JsonProperty(PropertyName="simple_buoyancy_vertical_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource SimpleBuoyancyVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyVerticalWallEquationSource), "FohannoPolidoriVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_vertical_wall_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyVerticalWallUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for horizontal surfaces " +
                     "with heat flow directed for stable thermal stratification")]
        [JsonProperty(PropertyName="simple_buoyancy_stable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource SimpleBuoyancyStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_stable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for passive horizontal s" +
                     "urfaces with heat flow for unstable thermal stratification")]
        [JsonProperty(PropertyName="simple_buoyancy_unstable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource SimpleBuoyancyUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableHorizontalEquationSource), "AlamdariHammondUnstableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_unstable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
                     " heat flow for stable thermal stratification")]
        [JsonProperty(PropertyName="simple_buoyancy_stable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource SimpleBuoyancyStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_stable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for tilted surfaces with" +
                     " heat flow for unstable thermal stratification")]
        [JsonProperty(PropertyName="simple_buoyancy_unstable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource SimpleBuoyancyUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_unstable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with no HVAC or when HVAC is off This is for all window surfaces")]
        [JsonProperty(PropertyName="simple_buoyancy_windows_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource SimpleBuoyancyWindowsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_SimpleBuoyancyWindowsEquationSource), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="simple_buoyancy_windows_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleBuoyancyWindowsEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for verti" +
                     "cal walls")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_vertical_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource FloorHeatCeilingCoolVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolVerticalWallEquationSource), "KhalifaEq3WallAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_vertical_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
                     "ve horizontal surfaces with heat flow for stable thermal stratification")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_stable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource FloorHeatCeilingCoolStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_stable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for passi" +
                     "ve horizontal surfaces with heat flow for unstable thermal stratification")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_unstable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource FloorHeatCeilingCoolUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableHorizontalEquationSource), "KhalifaEq4CeilingAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_unstable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a flo" +
                     "or with active heating elements")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_heated_floor_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource FloorHeatCeilingCoolHeatedFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolHeatedFloorEquationSource), "AwbiHattonHeatedFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_heated_floor_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolHeatedFloorEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for a cei" +
                     "ling with active cooling elements")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_chilled_ceiling_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource FloorHeatCeilingCoolChilledCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolChilledCeilingEquationSource), "KaradagChilledCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_chilled_ceiling_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolChilledCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
                     "d surfaces with heat flow for stable thermal stratification")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_stable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource FloorHeatCeilingCoolStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_stable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for tilte" +
                     "d surfaces with heat flow for unstable thermal stratification")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_unstable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource FloorHeatCeilingCoolUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_unstable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-floor heating and/or in-ceiling cooling This is for all w" +
                     "indow surfaces")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_window_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource FloorHeatCeilingCoolWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_FloorHeatCeilingCoolWindowEquationSource), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="floor_heat_ceiling_cool_window_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FloorHeatCeilingCoolWindowEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for vertical walls that are no" +
                     "t actively heated")]
        [JsonProperty(PropertyName="wall_panel_heating_vertical_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource WallPanelHeatingVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingVerticalWallEquationSource), "KhalifaEq6NonHeatedWalls");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_vertical_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for vertical walls that are be" +
                     "ing actively heated")]
        [JsonProperty(PropertyName="wall_panel_heating_heated_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource WallPanelHeatingHeatedWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingHeatedWallEquationSource), "AwbiHattonHeatedWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_heated_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingHeatedWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
                     "eat flow directed for stable thermal stratification")]
        [JsonProperty(PropertyName="wall_panel_heating_stable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource WallPanelHeatingStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_stable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for horizontal surfaces with h" +
                     "eat flow directed for unstable thermal stratification")]
        [JsonProperty(PropertyName="wall_panel_heating_unstable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource WallPanelHeatingUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableHorizontalEquationSource), "KhalifaEq7Ceiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_unstable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
                     "flow for stable thermal stratification")]
        [JsonProperty(PropertyName="wall_panel_heating_stable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource WallPanelHeatingStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_stable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for tilted surfaces with heat " +
                     "flow for unstable thermal stratification")]
        [JsonProperty(PropertyName="wall_panel_heating_unstable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource WallPanelHeatingUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_unstable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with in-wall panel heating This is for all window surfaces")]
        [JsonProperty(PropertyName="wall_panel_heating_window_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource WallPanelHeatingWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_WallPanelHeatingWindowEquationSource), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="wall_panel_heating_window_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string WallPanelHeatingWindowEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for vertical walls not directly af" +
                     "fected by heater")]
        [JsonProperty(PropertyName="convective_zone_heater_vertical_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource ConvectiveZoneHeaterVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallEquationSource), "FohannoPolidoriVerticalWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_vertical_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for vertical walls that are direct" +
                     "ly affected by heater Walls are considered \"near\" when listed in field set for F" +
                     "raction of Radiant Energy to Surface")]
        [JsonProperty(PropertyName="convective_zone_heater_vertical_walls_near_heater_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterVerticalWallsNearHeaterEquationSource), "KhalifaEq5WallNearHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_vertical_walls_near_heater_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterVerticalWallsNearHeaterEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
                     "flow directed for stable thermal stratification")]
        [JsonProperty(PropertyName="convective_zone_heater_stable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource ConvectiveZoneHeaterStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_stable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for horizontal surfaces with heat " +
                     "flow directed for unstable thermal stratification")]
        [JsonProperty(PropertyName="convective_zone_heater_unstable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource ConvectiveZoneHeaterUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableHorizontalEquationSource), "KhalifaEq7Ceiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_unstable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
                     " for stable thermal stratification")]
        [JsonProperty(PropertyName="convective_zone_heater_stable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource ConvectiveZoneHeaterStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_stable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for tilted surfaces with heat flow" +
                     " for unstable thermal stratification")]
        [JsonProperty(PropertyName="convective_zone_heater_unstable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource ConvectiveZoneHeaterUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_unstable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with convective heater This is for all window surfaces")]
        [JsonProperty(PropertyName="convective_zone_heater_windows_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource ConvectiveZoneHeaterWindowsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_ConvectiveZoneHeaterWindowsEquationSource), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="convective_zone_heater_windows_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ConvectiveZoneHeaterWindowsEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " wall surfaces")]
        [JsonProperty(PropertyName="central_air_diffuser_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource CentralAirDiffuserWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWallEquationSource), "GoldsteinNovoselacCeilingDiffuserWalls");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="central_air_diffuser_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CentralAirDiffuserWallEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " ceiling surfaces")]
        [JsonProperty(PropertyName="central_air_diffuser_ceiling_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource CentralAirDiffuserCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserCeilingEquationSource), "FisherPedersenCeilingDiffuserCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="central_air_diffuser_ceiling_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CentralAirDiffuserCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " floor surfaces")]
        [JsonProperty(PropertyName="central_air_diffuser_floor_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource CentralAirDiffuserFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserFloorEquationSource), "GoldsteinNovoselacCeilingDiffuserFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="central_air_diffuser_floor_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CentralAirDiffuserFloorEquationUserCurveName { get; set; } = "";
        

        [Description("Applies to zone with mechanical forced central air with diffusers This is for all" +
                     " window surfaces")]
        [JsonProperty(PropertyName="central_air_diffuser_window_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource CentralAirDiffuserWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_CentralAirDiffuserWindowEquationSource), "GoldsteinNovoselacCeilingDiffuserWindow");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="central_air_diffuser_window_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CentralAirDiffuserWindowEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_vertical_wall_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource MechanicalZoneFanCirculationVerticalWallEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationVerticalWallEquationSource), "KhalifaEq3WallAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_vertical_wall_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationVerticalWallEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_stable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource MechanicalZoneFanCirculationStableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableHorizontalEquationSource), "AlamdariHammondStableHorizontal");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_stable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationStableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_unstable_horizontal_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource MechanicalZoneFanCirculationUnstableHorizontalEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableHorizontalEquationSource), "KhalifaEq4CeilingAwayFromHeat");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_unstable_horizontal_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationUnstableHorizontalEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_stable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource MechanicalZoneFanCirculationStableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationStableTiltedEquationSource), "WaltonStableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_stable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationStableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_unstable_tilted_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource MechanicalZoneFanCirculationUnstableTiltedEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationUnstableTiltedEquationSource), "WaltonUnstableHorizontalOrTilt");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_unstable_tilted_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationUnstableTiltedEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_window_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource MechanicalZoneFanCirculationWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MechanicalZoneFanCirculationWindowEquationSource), "ISO15099Windows");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mechanical_zone_fan_circulation_window_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MechanicalZoneFanCirculationWindowEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_buoyancy_assisting_flow_on_walls_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyAssistingFlowOnWallsEquationSource), "BeausoleilMorrisonMixedAssistedWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_buoyancy_assisting_flow_on_walls_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeBuoyancyAssistingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_buoyancy_opposing_flow_on_walls_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeBuoyancyOpposingFlowOnWallsEquationSource), "BeausoleilMorrisonMixedOpposingWall");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_buoyancy_opposing_flow_on_walls_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeBuoyancyOpposingFlowOnWallsEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_stable_floor_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource MixedRegimeStableFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableFloorEquationSource), "BeausoleilMorrisonMixedStableFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_stable_floor_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeStableFloorEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_unstable_floor_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource MixedRegimeUnstableFloorEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableFloorEquationSource), "BeausoleilMorrisonMixedUnstableFloor");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_unstable_floor_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeUnstableFloorEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_stable_ceiling_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource MixedRegimeStableCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeStableCeilingEquationSource), "BeausoleilMorrisonMixedStableCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_stable_ceiling_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeStableCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_unstable_ceiling_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource MixedRegimeUnstableCeilingEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeUnstableCeilingEquationSource), "BeausoleilMorrisonMixedUnstableCeiling");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_unstable_ceiling_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeUnstableCeilingEquationUserCurveName { get; set; } = "";
        

        [Description("reference choice fields")]
        [JsonProperty(PropertyName="mixed_regime_window_equation_source", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource MixedRegimeWindowEquationSource { get; set; } = (SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource)Enum.Parse(typeof(SurfaceConvectionAlgorithm_Inside_AdaptiveModelSelections_MixedRegimeWindowEquationSource), "GoldsteinNovoselacCeilingDiffuserWindow");
        

        [Description("The SurfaceConvectionAlgorithm:Inside:UserCurve named in this field is used when " +
                     "the previous field is set to UserCurve")]
        [JsonProperty(PropertyName="mixed_regime_window_equation_user_curve_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixedRegimeWindowEquationUserCurveName { get; set; } = "";
    }
}