using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.Economics
{
    [Description(@"Defines the name of a utility cost tariff, the type of tariff, and other details about the overall tariff. Each other object that is part of the tariff model references the tariff name. See UtilityCost:Charge:Simple, UtilityCost:Charge:Block, UtilityCost:Ratchet, UtilityCost:Qualify, UtilityCost:Variable and UtilityCost:Computation objects.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class UtilityCost_Tariff : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The name of any standard meter or custom meter or but usually set to either Elect" +
                     "ricity:Facility or Gas:Facility")]
        [JsonProperty(PropertyName="output_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OutputMeterName { get; set; } = "";
        

        [Description("A choice that allows several different predefined conversion factors to be used; " +
                     "otherwise user defined conversion factors are used as defined in the next two fi" +
                     "elds. If left blank m3 is used for water meters and kWh are used for all other m" +
                     "eters.")]
        [JsonProperty(PropertyName="conversion_factor_choice", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Tariff_ConversionFactorChoice ConversionFactorChoice { get; set; } = (UtilityCost_Tariff_ConversionFactorChoice)Enum.Parse(typeof(UtilityCost_Tariff_ConversionFactorChoice), "CCF");
        

        [Description(@"Is a multiplier used to convert energy into the units specified by the utility in their tariff. If left blank it defaults to 1 (no conversion). This field should will be used only if Conversion Factor Choice is set to UserDefined. Within EnergyPlus energy always has units of J (joules). For conversion from J to kWh use the value of 0.0000002778. This is also used for all objects that reference the UtilityCost:Tariff.")]
        [JsonProperty(PropertyName="energy_conversion_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> EnergyConversionFactor { get; set; } = null;
        

        [Description(@"Is a multiplier used to convert demand into the units specified by the utility in their tariff. If left blank it defaults to 1 (no conversion). This field should will be used only if Conversion Factor Choice is set to UserDefined. Within EnergyPlus demand always has units of J/s (joules/sec) which equivalent to W (watts). For conversion from W to kW use the value of 0.001. This is also used for all objects that reference the UtilityCost:Tariff.")]
        [JsonProperty(PropertyName="demand_conversion_factor", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DemandConversionFactor { get; set; } = null;
        

        [Description(@"The name of the schedule that defines the time-of-use periods that occur each day. The values for the different variables are: 1 for Peak. 2 for Shoulder. 3 for OffPeak. 4 for MidPeak. The following variables are created automatically if these different periods are used in the schedule and include: TotalEnergy, TotalDemand, PeakEnergy, PeakDemand, ShoulderEnergy, ShoulderDemand, OffPeakEnergy, OffPeakDemand, MidPeakEnergy, MidPeakDemand Some special variables are created that include: PeakExceedsOffPeak, OffPeakExceedsPeak, PeakExceedsMidPeak, MidPeakExceedsPeak, PeakExceedsShoulder, ShoulderExceedsPeak, Others include: PeakAndShoulderEnergy, PeakAndShoulderDemand, PeakAndMidPeakEnergy, PeakAndMidPeakDemand, ShoulderAndOffPeakEnergy, ShoulderAndOffPeakDemand, PeakAndOffPeakEnergy, PeakAndOffPeakDemand, RealTimePriceCosts, AboveCustomerBaseCosts, BelowCustomerBaseCosts, AboveCustomerBaseEnergy, BelowCustomerBaseEnergy")]
        [JsonProperty(PropertyName="time_of_use_period_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TimeOfUsePeriodScheduleName { get; set; } = "";
        

        [Description(@"The name of a schedule that defines the seasons. The schedule values are: 1 for Winter. 2 for Spring. 3 for Summer. 4 for Autumn. Variables are automatically created if a season schedule is used. These variables are set to 1 within the season and 0 for the months that are not in the season. The variables are: IsWinter, IsNotWinter, IsSpring, IsNotSpring, IsSummer, IsNotSummer, IsAutumn, IsNotAutumn.")]
        [JsonProperty(PropertyName="season_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string SeasonScheduleName { get; set; } = "";
        

        [Description(@"The name of the schedule that defines the billing periods of the year. Normally this entry is allowed to default and a schedule will be internally used that has the breaks between billing periods occurring at the same time as the breaks between months i.e. at midnight prior to the first day of the month. If other billing periods are used such as two month cycles or a single bill for an entire season such as some natural gas companies do in the summer then the month schedule may be used to redefine it. Make sure that the month schedule and season schedule are consistent otherwise an error will be issued.")]
        [JsonProperty(PropertyName="month_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MonthScheduleName { get; set; } = "";
        

        [Description(@"The determination of demand can vary by utility. Some utilities use the peak instantaneous demand measured but most use a fifteen minute average demand or a one hour average demand. Some gas utilities measure demand as the use during the peak day or peak week.")]
        [JsonProperty(PropertyName="demand_window_length", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Tariff_DemandWindowLength DemandWindowLength { get; set; } = (UtilityCost_Tariff_DemandWindowLength)Enum.Parse(typeof(UtilityCost_Tariff_DemandWindowLength), "Day");
        

        [Description("The fixed monthly service charge that many utilities have. The entry may be numer" +
                     "ic and gets added to the ServiceCharges variable or if a variable name is entere" +
                     "d here its values for each month are used.")]
        [JsonProperty(PropertyName="monthly_charge_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MonthlyChargeOrVariableName { get; set; } = "";
        

        [Description("The minimum total charge for the tariff or if a variable name is entered here its" +
                     " values for each month are used.")]
        [JsonProperty(PropertyName="minimum_monthly_charge_or_variable_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MinimumMonthlyChargeOrVariableName { get; set; } = "";
        

        [Description("Used with real time pricing rates. The name of a schedule that contains the cost " +
                     "of energy for that particular time period of the year. Real time rates can be mo" +
                     "deled using a charge schedule with the actual real time prices entered in the sc" +
                     "hedule.")]
        [JsonProperty(PropertyName="real_time_pricing_charge_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string RealTimePricingChargeScheduleName { get; set; } = "";
        

        [Description("Used with real time pricing rates. The name of a schedule that contains the basel" +
                     "ine energy use for the customer. Many real time rates apply the charges as a cre" +
                     "dit or debit only to the difference between the baseline use and the actual use." +
                     "")]
        [JsonProperty(PropertyName="customer_baseline_load_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string CustomerBaselineLoadScheduleName { get; set; } = "";
        

        [Description(@"The group name of the tariff such as distribution transmission supplier etc. If more than one tariff with the same group name is present and qualifies only the lowest cost tariff is used. Usually the group name field is left blank which results in all tariffs using the same meter variable being compared and the lowest cost one being selected.")]
        [JsonProperty(PropertyName="group_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GroupName { get; set; } = "";
        

        [Description(@"Sets whether the tariff is used for buying selling or both to the utility. This should be allowed to default to buyFromUtility unless a power generation system is included in the building that may generate more power than the building needs during the year")]
        [JsonProperty(PropertyName="buy_or_sell", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public UtilityCost_Tariff_BuyOrSell BuyOrSell { get; set; } = (UtilityCost_Tariff_BuyOrSell)Enum.Parse(typeof(UtilityCost_Tariff_BuyOrSell), "BuyFromUtility");
    }
}