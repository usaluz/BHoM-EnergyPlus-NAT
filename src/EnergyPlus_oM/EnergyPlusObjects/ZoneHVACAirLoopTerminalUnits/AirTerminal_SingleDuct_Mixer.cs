using System;
using System.ComponentModel;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.ZoneHVACAirLoopTerminalUnits
{
    [Description(@"The mixer air terminal unit provides a means of supplying central system air to the air inlet or outlet side of a zoneHVAC equipment such as a four pipe fan coil unit. Normally the central air would be ventilation air from a dedicated outdoor air system (DOAS).")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class AirTerminal_SingleDuct_Mixer : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [Description("The type of ZoneHVAC equipment to which this terminal mixer will be connected.")]
        [JsonProperty(PropertyName="zonehvac_unit_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType ZonehvacUnitObjectType { get; set; } = (AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_ZonehvacUnitObjectType), "AirLoopHVACUnitarySystem");
        

        [Description("The name of ZoneHVAC equipment to which this terminal mixer will be connected.")]
        [JsonProperty(PropertyName="zonehvac_unit_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ZonehvacUnitObjectName { get; set; } = "";
        

        [Description(@"This is the outlet air node name of the mixer. This will be the inlet air node name of the ZoneHVAC equipment if the connection type in the input field Mixer Connection Type below is InletSide, else this will be an inlet air node name of the conditioned zone if the connection type in the input field Mixer Connection Type below is SupplySide.")]
        [JsonProperty(PropertyName="mixer_outlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixerOutletNodeName { get; set; } = "";
        

        [Description("The primary air (treated outdoor air) inlet node name of the mixer. This will be " +
                     "an outlet air node name of an AirLoopHVAC:ZoneSplitter or AirLoopHVAC:SupplyPlen" +
                     "um providing the connection to the DOA system.")]
        [JsonProperty(PropertyName="mixer_primary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixerPrimaryAirInletNodeName { get; set; } = "";
        

        [Description(@"The secondary air (recirculating air) inlet node name of the mixer. This will be the outlet air node name of the ZoneHVAC equipment if the connection type in the input field mixer Connection Type below is SupplySide, or else this will be an exhaust air node name of the conditioned zone if the connection type in the input field Mixer Connection Type below is InletSide.")]
        [JsonProperty(PropertyName="mixer_secondary_air_inlet_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string MixerSecondaryAirInletNodeName { get; set; } = "";
        

        [Description(@"This input field allows user to specify the mixer connection type. Valid choices are InletSide or SupplySide. This is a required input field. If the mixer connection type selected is InletSide, then the mixer is connected on the inlet side of the ZoneHVAC equipment, or else if the mixer connection type selected is SupplySide, then the mixer is connected at the outlet side of the ZoneHVAC equipment.")]
        [JsonProperty(PropertyName="mixer_connection_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_Mixer_MixerConnectionType MixerConnectionType { get; set; } = (AirTerminal_SingleDuct_Mixer_MixerConnectionType)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_MixerConnectionType), "InletSide");
        

        [Description(@"When the name of a DesignSpecification:OutdoorAir object is entered, the terminal unit will adjust flow to meet this outdoor air requirement. If Outdoor Air Flow per Person is non-zero, then the outdoor air requirement will be computed based on the current number of occupants in the zone, as for demand controlled ventilation. If this field is blank, then the terminal unit will be controlled using the DesignSpecification:OutdoorAir objec referenced in the Sizing:Zone object.")]
        [JsonProperty(PropertyName="design_specification_outdoor_air_object_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string DesignSpecificationOutdoorAirObjectName { get; set; } = "";
        

        [Description("CurrentOccupancy models demand controlled ventilation using the current number of" +
                     " people DesignOccupancy uses the total Number of People in the zone and is const" +
                     "ant")]
        [JsonProperty(PropertyName="per_person_ventilation_rate_mode", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode PerPersonVentilationRateMode { get; set; } = (AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode)Enum.Parse(typeof(AirTerminal_SingleDuct_Mixer_PerPersonVentilationRateMode), "CurrentOccupancy");
    }
}