using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ElectricLoadCenterGeneratorSpecifications
{
    [Description("Describes a subpanel a list of meters that can be reported are available after a " +
                 "run on the meter dictionary file (.mdd) if the Output:VariableDictionary has bee" +
                 "n requested.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class ElectricLoadCenter_Distribution : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("Name of an ElectricLoadCenter:Generators object")]
        [JsonProperty(PropertyName="generator_list_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorListName { get; set; } = "";
        

        [Description("Determines how generators are to be controlled Required if Generator List is ente" +
                     "red.")]
        [JsonProperty(PropertyName="generator_operation_scheme_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Distribution_GeneratorOperationSchemeType GeneratorOperationSchemeType { get; set; } = (ElectricLoadCenter_Distribution_GeneratorOperationSchemeType)Enum.Parse(typeof(ElectricLoadCenter_Distribution_GeneratorOperationSchemeType), "Baseload");
        

        [JsonProperty(PropertyName="generator_demand_limit_scheme_purchased_electric_demand_limit", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> GeneratorDemandLimitSchemePurchasedElectricDemandLimit { get; set; } = null;
        

        [Description("required when Generator Operation Scheme Type=TrackSchedule schedule values in Wa" +
                     "tts")]
        [JsonProperty(PropertyName="generator_track_schedule_name_scheme_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorTrackScheduleNameSchemeScheduleName { get; set; } = "";
        

        [Description("required when Generator Operation Scheme Type=TrackMeter")]
        [JsonProperty(PropertyName="generator_track_meter_scheme_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string GeneratorTrackMeterSchemeMeterName { get; set; } = "";
        

        [JsonProperty(PropertyName="electrical_buss_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Distribution_ElectricalBussType ElectricalBussType { get; set; } = (ElectricLoadCenter_Distribution_ElectricalBussType)Enum.Parse(typeof(ElectricLoadCenter_Distribution_ElectricalBussType), "AlternatingCurrent");
        

        [Description("required when Electrical Buss Type=DirectCurrentWithInverter, DirectCurrentWithIn" +
                     "verterDCStorage, or DirectCurrentWithInverterACStorage")]
        [JsonProperty(PropertyName="inverter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string InverterName { get; set; } = "";
        

        [Description("required when Electrical Buss Type=AlternatingCurrentWithStorage, DirectCurrentWi" +
                     "thInverterDCStorage, or DirectCurrentWithInverterACStorage")]
        [JsonProperty(PropertyName="electrical_storage_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ElectricalStorageObjectName { get; set; } = "";
        

        [Description("required when power needs to be output from on-site generation or storage to the " +
                     "grid via transformer")]
        [JsonProperty(PropertyName="transformer_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string TransformerObjectName { get; set; } = "";
        

        [Description("Select method to govern how storage charge and discharge is controlled TrackFacil" +
                     "ityElectricDemandStoreExcessOnSite indicates that storage control will follow th" +
                     "e facility power demand while accounting for any on-site generation. Only excess" +
                     " on site generation  gets stored (legacy behavior). TrackMeterDemandStoreExcessO" +
                     "nSite indicates that storage discharge control will follow an electric meter nam" +
                     "ed in the field called Storage Control Track Meter Name. This scheme is similiar" +
                     " to TrackFacilityElectricDemandStoreExcessOnSite except that instead of the main" +
                     " facility electric meter, the control is based off of a user-selected meter. Tra" +
                     "ckChargeDischargeSchedules indicates that control will follow the charging and d" +
                     "ischarging power and schedules defined in the fields called Maximum Storage Char" +
                     "ge Grid Supply Power, Storage Charge Grid Supply Power Fraction Schedule Name, D" +
                     "esign Storage Discharge Grid Export Power, and Storage Discharge Grid Export Fra" +
                     "ction Schedule Name. FacilityDemandLeveling indicates that storage control will " +
                     "attempt to control the facility\'s power demand drawn from the utility service to" +
                     " a prescribed level. The target utility demand is entered in the fields called S" +
                     "torage Control Utility Demand Limit and Storage Control Utility Demand Limit Fra" +
                     "ction Schedule Name This scheme first accounts for any on-site generation and du" +
                     "ring times of high use will discharge storage to reduce facility grid demand to " +
                     "meet the target level and during times of low use will charge storage from the g" +
                     "rid to increase facility grid demand to meet the target level.")]
        [JsonProperty(PropertyName="storage_operation_scheme", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public ElectricLoadCenter_Distribution_StorageOperationScheme StorageOperationScheme { get; set; } = (ElectricLoadCenter_Distribution_StorageOperationScheme)Enum.Parse(typeof(ElectricLoadCenter_Distribution_StorageOperationScheme), "TrackFacilityElectricDemandStoreExcessOnSite");
        

        [Description("required when Storage Operation Scheme is set to TrackMeterDemandStoreExcessOnSit" +
                     "e.")]
        [JsonProperty(PropertyName="storage_control_track_meter_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageControlTrackMeterName { get; set; } = "";
        

        [Description(@"Name of an ElectricLoadCenter:Storage:Converter used to convert AC to DC when charging DC storage from grid supply. A converter is expected when using Storage Operation Schemes FacilityDemandLeveling or TrackChargeDischargeSchedules A single bidirectional device will reference both an inverter object (DC to AC) and a converter object (AC to DC).")]
        [JsonProperty(PropertyName="storage_converter_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageConverterObjectName { get; set; } = "";
        

        [Description("Fraction of storage capacity used as upper limit for controlling charging, for al" +
                     "l storage operation schemes.")]
        [JsonProperty(PropertyName="maximum_storage_state_of_charge_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MaximumStorageStateOfChargeFraction { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("Fraction of storage capacity used as lower limit for controlling discharging, for" +
                     " all storage operation schemes.")]
        [JsonProperty(PropertyName="minimum_storage_state_of_charge_fraction", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> MinimumStorageStateOfChargeFraction { get; set; } = Double.Parse("0", CultureInfo.InvariantCulture);
        

        [Description(@"Maximum rate that electric power can be charged into storage. Storage charging adjusted downward for conversion losses. Rate is modified by fractional values in the schedule named in the next field. Required field when using Storage Operation Schemes FacilityDemandLeveling or TrackChargeDischargeSchedules.")]
        [JsonProperty(PropertyName="design_storage_control_charge_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignStorageControlChargePower { get; set; } = null;
        

        [Description("Controls timing and magnitude of charging storage. Required field if Storage Oper" +
                     "ation Scheme is set to TrackChargeDischargeSchedules. Schedule values should be " +
                     "fractions from 0.0 to 1.0, inclusive.")]
        [JsonProperty(PropertyName="storage_charge_power_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageChargePowerFractionScheduleName { get; set; } = "";
        

        [Description("Maximum rate that electric power can be discharged from storage. Rate is modified" +
                     " by fractional values in the schedule named in the next field. Required field wh" +
                     "en using Storage Operation Schemes FacilityDemandLeveling or TrackChargeDischarg" +
                     "eSchedules.")]
        [JsonProperty(PropertyName="design_storage_control_discharge_power", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignStorageControlDischargePower { get; set; } = null;
        

        [Description("Controls timing and magnitude of discharging storage Required field if Storage Op" +
                     "eration Scheme is set to TrackChargeDischargeSchedules. Schedule values should b" +
                     "e fractions from 0.0 to 1.0, inclusive.")]
        [JsonProperty(PropertyName="storage_discharge_power_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageDischargePowerFractionScheduleName { get; set; } = "";
        

        [Description("Target utility service demand power for discharge control. Storage draws are adju" +
                     "sted upwards for conversion losses. Required field for FacilityDemandLeveling st" +
                     "orage operation scheme")]
        [JsonProperty(PropertyName="storage_control_utility_demand_target", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> StorageControlUtilityDemandTarget { get; set; } = null;
        

        [Description(@"Modifies the target utility service demand power over time. Schedule values should be fractions from -1.0 to 1.0, inclusive. if omitted a schedule value of 1.0 is used. Negative values indicate export to grid Schedule is used if Storage Operation Scheme is set to FacilityDemandLeveling.")]
        [JsonProperty(PropertyName="storage_control_utility_demand_target_fraction_schedule_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string StorageControlUtilityDemandTargetFractionScheduleName { get; set; } = "";
    }
}