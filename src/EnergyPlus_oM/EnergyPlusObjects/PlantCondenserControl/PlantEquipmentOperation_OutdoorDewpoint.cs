using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for outdoor dewpoint temperature range operation" +
                 ". Specifies one or more groups of equipment which are available to operate for s" +
                 "uccessive outdoor dewpoint temperature ranges.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_OutdoorDewpoint : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_1_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange1LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_1_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange1UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_1_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range1EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_2_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange2LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_2_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange2UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_2_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range2EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_3_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange3LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_3_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange3UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_3_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range3EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_4_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange4LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_4_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange4UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_4_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range4EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_5_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange5LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_5_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange5UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_5_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range5EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_6_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange6LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_6_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange6UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_6_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range6EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_7_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange7LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_7_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange7UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_7_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range7EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_8_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange8LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_8_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange8UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_8_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range8EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_9_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange9LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_9_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange9UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_9_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range9EquipmentListName { get; set; } = "";
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_10_lower_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange10LowerLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="dewpoint_temperature_range_10_upper_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DewpointTemperatureRange10UpperLimit { get; set; } = null;
        

        [JsonProperty(PropertyName="range_10_equipment_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Range10EquipmentListName { get; set; } = "";
    }
}