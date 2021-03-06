using System;
using System.ComponentModel;
using System.Globalization;
using BH.oM.Base;
using Newtonsoft.Json;

namespace BH.oM.Adapters.EnergyPlus.PlantCondenserControl
{
    [Description("Plant equipment operation scheme for simpler input to control thermal (ice) energ" +
                 "y storage systems. It replaces a host of setpoint managers with simple, single i" +
                 "nput values. For more complex controls, use the ComponentSetpoint scheme.")]
    [JsonObject(Newtonsoft.Json.MemberSerialization.OptIn)]
    public class PlantEquipmentOperation_ThermalEnergyStorage : BHoMObject, IEnergyPlusNode
    {
        

        [Description("This will be the main key of this instance. It will be the main key of the serial" +
                     "ization and all other properties will be sub properties of this key.")]
        [JsonProperty(PropertyName="name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string NodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="on_peak_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string OnPeakSchedule { get; set; } = "";
        

        [JsonProperty(PropertyName="charging_availability_schedule", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string ChargingAvailabilitySchedule { get; set; } = "";
        

        [Description("Single temperature for chiller outlet when not in cooling season or during on-pea" +
                     "k cooling (discharge)")]
        [JsonProperty(PropertyName="non_charging_chilled_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> NonChargingChilledWaterTemperature { get; set; } = null;
        

        [Description("Single temperature for chiller outlet when off-peak during cooling season (chargi" +
                     "ng)")]
        [JsonProperty(PropertyName="charging_chilled_water_temperature", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public System.Nullable<double> ChargingChilledWaterTemperature { get; set; } = null;
        

        [Description("This field is the type of object and should either be a chiller or some ice stora" +
                     "ge equipment.")]
        [JsonProperty(PropertyName="component_1_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType Component1ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component1ObjectType), "ChillerAbsorption");
        

        [Description("This field is the name of either the chiller or ice storage equipment on the loop" +
                     ".")]
        [JsonProperty(PropertyName="component_1_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component1Name { get; set; } = "";
        

        [Description("This field is the name of the inlet node for the component defined in the two pre" +
                     "vious input fields.")]
        [JsonProperty(PropertyName="component_1_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component1DemandCalculationNodeName { get; set; } = "";
        

        [Description("This field is the name of the outlet node for the component listed above.")]
        [JsonProperty(PropertyName="component_1_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component1SetpointNodeName { get; set; } = "";
        

        [Description("This field is the flow rate for the component listed above.")]
        [JsonProperty(PropertyName="component_1_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component1FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [Description("This field is the operation type for the component listed above. For this plant e" +
                     "quipment operation scheme, \"Cooling\" should be selected for chiller equipment wh" +
                     "ile ice storage equipment should be defined as \"Dual\".")]
        [JsonProperty(PropertyName="component_1_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType Component1OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component1OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_2_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType Component2ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component2ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_2_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component2Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component2DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component2SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_2_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component2FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_2_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType Component2OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component2OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_3_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType Component3ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component3ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_3_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component3Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component3DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component3SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_3_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component3FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_3_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType Component3OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component3OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_4_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType Component4ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component4ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_4_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component4Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component4DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component4SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_4_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component4FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_4_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType Component4OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component4OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_5_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType Component5ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component5ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_5_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component5Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component5DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component5SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_5_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component5FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_5_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType Component5OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component5OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_6_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType Component6ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component6ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_6_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component6Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component6DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component6SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_6_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component6FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_6_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType Component6OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component6OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_7_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType Component7ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component7ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_7_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component7Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component7DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component7SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_7_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component7FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_7_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType Component7OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component7OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_8_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType Component8ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component8ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_8_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component8Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component8DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component8SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_8_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component8FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_8_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType Component8OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component8OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_9_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType Component9ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component9ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_9_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component9Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component9DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component9SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_9_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component9FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_9_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType Component9OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component9OperationType), "Cooling");
        

        [JsonProperty(PropertyName="component_10_object_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType Component10ObjectType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component10ObjectType), "ChillerAbsorption");
        

        [JsonProperty(PropertyName="component_10_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component10Name { get; set; } = "";
        

        [JsonProperty(PropertyName="component_10_demand_calculation_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component10DemandCalculationNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_10_setpoint_node_name", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        public string Component10SetpointNodeName { get; set; } = "";
        

        [JsonProperty(PropertyName="component_10_flow_rate", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(BH.oM.Adapters.EnergyPlus.JsonConverters.EPNullToAutosizeJsonConverter))]
        public System.Nullable<double> Component10FlowRate { get; set; } = Double.Parse("-987654321", CultureInfo.InvariantCulture);
        

        [JsonProperty(PropertyName="component_10_operation_type", NullValueHandling=Newtonsoft.Json.NullValueHandling.Ignore)]
        [Newtonsoft.Json.JsonConverter(typeof(Newtonsoft.Json.Converters.StringEnumConverter))]
        public PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType Component10OperationType { get; set; } = (PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType)Enum.Parse(typeof(PlantEquipmentOperation_ThermalEnergyStorage_Component10OperationType), "Cooling");
    }
}