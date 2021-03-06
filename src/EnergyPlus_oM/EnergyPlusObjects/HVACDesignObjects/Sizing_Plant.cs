using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.HVACDesignObjects
{
    [Description(@"Specifies the input needed to autosize plant loop flow rates and equipment capacities. This information is initially used by components that use water for heating or cooling such as hot or chilled water coils to calculate their maximum water flow rates. These flow rates are then summed for use in calculating the Plant Loop flow rates.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class Sizing_Plant : BHoMObject
    {
        

        [Description("Enter the name of a PlantLoop or a CondenserLoop object")]
        [JsonProperty(PropertyName="plant_or_condenser_loop_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string PlantOrCondenserLoopName { get; set; } = "";
        

        [JsonProperty(PropertyName="loop_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Plant_LoopType LoopType { get; set; } = (Sizing_Plant_LoopType)Enum.Parse(typeof(Sizing_Plant_LoopType), "Condenser");
        

        [JsonProperty(PropertyName="design_loop_exit_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> DesignLoopExitTemperature { get; set; } = null;
        

        [JsonProperty(PropertyName="loop_design_temperature_difference", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> LoopDesignTemperatureDifference { get; set; } = null;
        

        [Description("if Coincident is chosen, then sizing is based on HVAC Sizing Simulations and the " +
                     "input field called Do HVAC Sizing Simulation for Sizing Periods in SimulationCon" +
                     "trol must be set to Yes")]
        [JsonProperty(PropertyName="sizing_option", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Plant_SizingOption SizingOption { get; set; } = (Sizing_Plant_SizingOption)Enum.Parse(typeof(Sizing_Plant_SizingOption), "NonCoincident");
        

        [Description("this is used in the coincident sizing algorithm to apply a running average to pea" +
                     "k flow rates that occur during HVAC Sizing Simulations")]
        [JsonProperty(PropertyName="zone_timesteps_in_averaging_window", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ZoneTimestepsInAveragingWindow { get; set; } = Double.Parse("1", CultureInfo.InvariantCulture);
        

        [Description("this is used to adjust the result for coincident sizing by applying a sizing fact" +
                     "or")]
        [JsonProperty(PropertyName="coincident_sizing_factor_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public Sizing_Plant_CoincidentSizingFactorMode CoincidentSizingFactorMode { get; set; } = (Sizing_Plant_CoincidentSizingFactorMode)Enum.Parse(typeof(Sizing_Plant_CoincidentSizingFactorMode), "GlobalCoolingSizingFactor");
    }
}