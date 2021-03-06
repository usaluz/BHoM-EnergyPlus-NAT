using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Schedules
{
    [Description("A Schedule:File:Shading points to a CSV file that has 8760-8784 hours of sunlit f" +
                 "raction data for all or some of the exterior surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Schedule_File_Shading : BHoMObject
    {
        

        [Description("The name of the file that writes all shading data.")]
        [JsonProperty(PropertyName="file_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string FileName { get; set; } = "";
    }
}