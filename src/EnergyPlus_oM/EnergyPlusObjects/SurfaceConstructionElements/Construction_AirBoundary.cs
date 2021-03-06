using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.SurfaceConstructionElements
{
    [Description(@"Indicates an open boundary between two zones. It may be used for base surfaces and fenestration surfaces. The two adjacent zones are grouped together for solar, daylighting and radiant exchange. When this construction type is used, the Outside Boundary Condition of the surface (or the base surface of a fenestration surface) must be either Surface or Zone. A base surface with Construction:AirBoundary cannot hold any fenestration surfaces.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Construction_AirBoundary : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("This field controls how air exchange is modeled across this boundary.")]
        [JsonProperty(PropertyName="air_exchange_method", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Construction_AirBoundary_AirExchangeMethod AirExchangeMethod { get; set; } = (Construction_AirBoundary_AirExchangeMethod)Enum.Parse(typeof(Construction_AirBoundary_AirExchangeMethod), "None");
        

        [Description("If the Air Exchange Method is SimpleMixing then this field specifies the air chan" +
                     "ges per hour using the volume of the smaller zone as the basis. If an AirflowNet" +
                     "work simulation is active this field is ignored.")]
        [JsonProperty(PropertyName="simple_mixing_air_changes_per_hour", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> SimpleMixingAirChangesPerHour { get; set; } = Double.Parse("0.5", CultureInfo.InvariantCulture);
        

        [Description("If the Air Exchange Method is SimpleMixing then this field specifies the air exch" +
                     "ange schedule. If this field is blank, the schedule is always 1.0. If an Airflow" +
                     "Network simulation is active this field is ignored.")]
        [JsonProperty(PropertyName="simple_mixing_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SimpleMixingScheduleName { get; set; } = "";
    }
}