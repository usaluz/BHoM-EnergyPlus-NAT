using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.OutputReporting
{
    [Description("Special keys to produce certain warning messages or effect certain simulation cha" +
                 "racteristics.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Output_Diagnostics : BHoMObject
    {
        

        [JsonProperty(PropertyName="diagnostics", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Collections.Generic.List<string> Diagnostics { get; set; } = null;
    }
}