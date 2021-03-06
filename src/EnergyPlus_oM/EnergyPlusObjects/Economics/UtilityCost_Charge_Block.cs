using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description("Used to compute energy and demand charges (or any other charges) that are structu" +
                 "red in blocks of charges. Multiple UtilityCost:Charge:Block objects may be defin" +
                 "ed for a single tariff and they will be added together.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UtilityCost_Charge_Block : BHoMObject
    {
        

        [Description(@"Charge Variable Name This is the name associated with the UtilityCost:Charge:Block object and will appear in the report. In addition the results of the UtilityCost:Charge:Block are stored in a variable with the same name. That way the results may be used for further calculation.")]
        [JsonProperty(PropertyName="utility_cost_charge_block_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string UtilityCostChargeBlockName { get; set; } = "";
        

        [Description("The name of the UtilityCost:Tariff that is associated with this UtilityCost:Charg" +
                     "e:Block.")]
        [JsonProperty(PropertyName="tariff_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TariffName { get; set; } = "";
        

        [Description(@"The name of the source used by the UtilityCost:Charge:Block. This is usually the name of the variable holding the energy or demand but may also be the name of any variable including the subtotal or basis if other charges are based on those. Typical values include totalEnergy totalDemand EnergyCharges DemandCharges ServiceCharges Basis Adjustments Surcharges Subtotal Taxes and Total. If it is a time-of-use rate then peakEnergy peakDemand shoulderEnergy shoulderDemand offPeakEnergy offPeakDemand midPeakEnergy and midPeakDemand. In addition see the Tariff Report to see other native variables that may be available. Also you can create additional user defined variables to model complex tariffs.")]
        [JsonProperty(PropertyName="source_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SourceVariable { get; set; } = "";
        

        [Description("If this is set to annual the calculations are performed for the UtilityCost:Charg" +
                     "e:Block for the entire year (all months) otherwise it is calculated only for tho" +
                     "se months in the season defined.")]
        [JsonProperty(PropertyName="season", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Charge_Block_Season Season { get; set; } = (UtilityCost_Charge_Block_Season)Enum.Parse(typeof(UtilityCost_Charge_Block_Season), "Annual");
        

        [Description("This field shows where the charge should be added. The reason to enter this field" +
                     " appropriately is so that the charge gets reported in a reasonable category. The" +
                     " charge automatically gets added to the variable that is the category.")]
        [JsonProperty(PropertyName="category_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Charge_Block_CategoryVariableName CategoryVariableName { get; set; } = (UtilityCost_Charge_Block_CategoryVariableName)Enum.Parse(typeof(UtilityCost_Charge_Block_CategoryVariableName), "Adjustment");
        

        [Description(@"If the blocks do not use all of the energy or demand from the source some energy and demand remains then the remaining amount should be assigned to a variable. If no variable is assigned and some amount of energy or demand is not used in the block structure a warning will be issued.")]
        [JsonProperty(PropertyName="remaining_into_variable", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RemainingIntoVariable { get; set; } = "";
        

        [Description(@"The sizes of the blocks are usually used directly but if a value or a variable is entered here the block sizes entered in the rest of the charge are first multiplied by the entered value prior to being used. This is common for rates that are kWh/kW rates and in that case the variable that holds the monthly total electric demand would be entered. If no value is entered a default value of one is assumed so that the block sizes remain exactly as entered. This field is unusual for the EnergyPlus syntax because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_multiplier_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSizeMultiplierValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_1_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize1ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_1_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block1CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_2_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize2ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_2_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block2CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_3_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize3ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_3_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block3CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_4_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize4ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_4_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block4CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_5_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize5ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_5_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block5CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_6_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize6ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_6_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block6CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_7_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize7ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_7_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block7CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_8_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize8ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_8_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block8CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_9_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize9ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_9_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block9CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_10_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize10ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_10_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block10CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_11_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize11ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_11_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block11CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_12_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize12ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_12_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block12CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_13_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize13ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_13_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block13CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_14_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize14ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_14_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block14CostPerUnitValueOrVariableName { get; set; } = "";
        

        [Description(@"The size of the block of the charges is entered here. For most rates that use multiple blocks this will be the value for the block size. Using remaining may be used when the remaining amount should be included in that block. This field is unusual because it can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_size_15_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string BlockSize15ValueOrVariableName { get; set; } = "";
        

        [Description("The cost of the block. This field is unusual for the EnergyPlus syntax because it" +
                     " can be either a number or a name of a variable.")]
        [JsonProperty(PropertyName="block_15_cost_per_unit_value_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Block15CostPerUnitValueOrVariableName { get; set; } = "";
    }
}