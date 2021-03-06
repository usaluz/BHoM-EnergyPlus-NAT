namespace BH.oM.Adapters.EnergyPlus.HVACTemplates
{
    public enum HVACTemplate_System_DedicatedOutdoorAir_CoolingCoilType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWater")]
        ChilledWater = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ChilledWaterDetailedFlatModel")]
        ChilledWaterDetailedFlatModel = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchangerAssistedChilledWater")]
        HeatExchangerAssistedChilledWater = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="HeatExchangerAssistedDX")]
        HeatExchangerAssistedDX = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="None")]
        None = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoSpeedDX")]
        TwoSpeedDX = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoStageDX")]
        TwoStageDX = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="TwoStageHumidityControlDX")]
        TwoStageHumidityControlDX = 8,
    }
}