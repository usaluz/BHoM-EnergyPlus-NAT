using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    [Description("Allows an additional heat source term to be added to the inside or outside surfac" +
                 "e boundary. A heat source can be added to either or both the inside and outside " +
                 "of the same surface.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class SurfaceProperty_HeatBalanceSourceTerm : BHoMObject
    {
        

        [JsonProperty(PropertyName="surface_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SurfaceName { get; set; } = "";
        

        [Description(@"The value of this schedule is the source term value for the inside face of this surface If this field is left blank, no inside surface source term will be applied. The schedule values are heat rate per surface area (W/m2), when positive schedule values indicate heat gain and negative values indicates loss.")]
        [JsonProperty(PropertyName="inside_face_heat_source_term_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InsideFaceHeatSourceTermScheduleName { get; set; } = "";
        

        [Description(@"The value of this schedule is the source term value for the outside face of this surface If this field is left blank, no outside surface source term will be applied. The schedule values are heat rate per surface area (W/m2), when positive schedule values indicate heat gain and negative values indicates loss.")]
        [JsonProperty(PropertyName="outside_face_heat_source_term_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutsideFaceHeatSourceTermScheduleName { get; set; } = "";
    }
}