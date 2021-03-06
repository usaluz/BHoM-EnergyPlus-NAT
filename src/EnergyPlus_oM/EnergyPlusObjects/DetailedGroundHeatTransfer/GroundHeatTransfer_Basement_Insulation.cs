using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.DetailedGroundHeatTransfer
{
    [Description("Describes the insulation used on an exterior basement wall for the Basement prepr" +
                 "ocessor ground heat transfer simulation.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class GroundHeatTransfer_Basement_Insulation : BHoMObject
    {
        

        [JsonProperty(PropertyName="rext_r_value_of_any_exterior_insulation", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> RextRValueOfAnyExteriorInsulation { get; set; } = null;
        

        [Description("True for full insulation False for insulation half way down side wall from grade " +
                     "line")]
        [JsonProperty(PropertyName="insfull_flag_is_the_wall_fully_insulated_", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated InsfullFlagIsTheWallFullyInsulated { get; set; } = (GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated)Enum.Parse(typeof(GroundHeatTransfer_Basement_Insulation_InsfullFlagIsTheWallFullyInsulated), "FALSE");
    }
}