using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"Allows the modeling of tariffs that include some type of seasonal ratcheting. Ratchets are most common when used with electric demand charges. A ratchet is when a utility requires that the demand charge for a month with a low demand may be increased to be more consistent with a month that set a higher demand charge.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UtilityCost_Ratchet : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Ratch" +
                     "et.")]
        [JsonProperty(PropertyName="tariff_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TariffName { get; set; } = "";
        

        [Description(@"When the ratcheted value exceeds the baseline value for a month the ratcheted value is used but when the baseline value is greater then the ratcheted value the baseline value is used. Usually the electric demand charge is used. The baseline source variable can be the results of another ratchet object. This allows utility tariffs that have multiple ratchets to be modeled.")]
        [JsonProperty(PropertyName="baseline_source_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BaselineSourceVariable { get; set; } = "";
        

        [Description(@"The variable that the ratchet is calculated from. It is often but not always the same as the baseline source variable. The ratcheting calculations using offset and multiplier are using the values from the adjustment source variable. If left blank the adjustment source variable is the same as the baseline source variable.")]
        [JsonProperty(PropertyName="adjustment_source_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string AdjustmentSourceVariable { get; set; } = "";
        

        [Description(@"The name of the season that is being examined. The maximum value for all of the months in the named season is what is used with the multiplier and offset. This is most commonly Summer or Annual. When Monthly is used the adjustment source variable is used directly for all months.")]
        [JsonProperty(PropertyName="season_from", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Ratchet_SeasonFrom SeasonFrom { get; set; } = (UtilityCost_Ratchet_SeasonFrom)Enum.Parse(typeof(UtilityCost_Ratchet_SeasonFrom), "Annual");
        

        [Description(@"The name of the season when the ratchet would be calculated. This is most commonly Winter. The ratchet only is applied to the months in the named season. The resulting variable for months not in the Season To selection will contain the values as appear in the baseline source variable.")]
        [JsonProperty(PropertyName="season_to", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Ratchet_SeasonTo SeasonTo { get; set; } = (UtilityCost_Ratchet_SeasonTo)Enum.Parse(typeof(UtilityCost_Ratchet_SeasonTo), "Annual");
        

        [Description(@"Often the ratchet has a clause such as ""the current month demand or 90% of the summer month demand"". For this case a value of 0.9 would be entered here as the multiplier. This value may be left blank if no multiplier is needed and a value of one will be used as a default.")]
        [JsonProperty(PropertyName="multiplier_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MultiplierValueOrVariableName { get; set; } = "";
        

        [Description(@"A less common strategy is to say that the ratchet must be all demand greater than a value in this case an offset that is added to the demand may be entered here. If entered it is common for the offset value to be negative representing that the demand be reduced. If no value is entered it is assumed to be zero and not affect the ratchet.")]
        [JsonProperty(PropertyName="offset_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OffsetValueOrVariableName { get; set; } = "";
    }
}