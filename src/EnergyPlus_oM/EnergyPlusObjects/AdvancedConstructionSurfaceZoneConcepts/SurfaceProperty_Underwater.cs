using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("This object sets up a convective water boundary condition for a surface The free " +
                 "stream temperature and velocity are scheduled. If the free stream velocity is ze" +
                 "ro, the surface will naturally convect with the surrounding water.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_Underwater : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This is the distance from the leading edge of the boundary layer development to t" +
                     "he centroid of the surface of interest. The value of this field is used as the d" +
                     "istance in the Reynolds number for evaluating the local convection coefficient.")]
        [JsonProperty(PropertyName="distance_from_surface_centroid_to_leading_edge_of_boundary_layer", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DistanceFromSurfaceCentroidToLeadingEdgeOfBoundaryLayer { get; set; } = null;
        

        [JsonProperty(PropertyName="free_stream_water_temperature_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FreeStreamWaterTemperatureSchedule { get; set; } = "";
        

        [JsonProperty(PropertyName="free_stream_water_velocity_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FreeStreamWaterVelocitySchedule { get; set; } = "";
    }
}