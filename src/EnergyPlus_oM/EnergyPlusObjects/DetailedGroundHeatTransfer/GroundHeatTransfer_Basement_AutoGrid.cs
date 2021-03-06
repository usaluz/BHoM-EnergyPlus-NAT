using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("AutoGrid only necessary when EquivSizing is false If the modeled building is not " +
                 "a rectangle or square, Equivalent sizing MUST be used to get accurate results")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_AutoGrid : BHoMObject
    {
        

        [JsonProperty(PropertyName="clearance_distance_from_outside_of_wall_to_edge_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ClearanceDistanceFromOutsideOfWallToEdge { get; set; } = Double.Parse("15", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slabx_x_dimension_of_the_building_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabxXDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty(PropertyName="slaby_y_dimension_of_the_building_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabyYDimensionOfTheBuildingSlab { get; set; } = null;
        

        [JsonProperty(PropertyName="concagheight_height_of_the_foundation_wall_above_grade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ConcagheightHeightOfTheFoundationWallAboveGrade { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="slabdepth_thickness_of_the_floor_slab", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SlabdepthThicknessOfTheFloorSlab { get; set; } = Double.Parse("0.1", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="basedepth_depth_of_the_basement_wall_below_grade", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> BasedepthDepthOfTheBasementWallBelowGrade { get; set; } = Double.Parse("2", CultureInfo.InvariantCulture);
    }
}