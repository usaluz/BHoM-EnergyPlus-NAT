namespace BH.oM.Adapters.EnergyPlus.ZoneHVACRadiativeConvectiveUnits
{
    public enum ZoneHVAC_LowTemperatureRadiant_ConstantFlow_Design_TemperatureControlType
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanAirTemperature")]
        MeanAirTemperature = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="MeanRadiantTemperature")]
        MeanRadiantTemperature = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="OperativeTemperature")]
        OperativeTemperature = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorDryBulbTemperature")]
        OutdoorDryBulbTemperature = 4,
        
        [System.Runtime.Serialization.EnumMember(Value="OutdoorWetBulbTemperature")]
        OutdoorWetBulbTemperature = 5,
        
        [System.Runtime.Serialization.EnumMember(Value="RunningMeanOutdoorDryBulbTemperature")]
        RunningMeanOutdoorDryBulbTemperature = 6,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceFaceTemperature")]
        SurfaceFaceTemperature = 7,
        
        [System.Runtime.Serialization.EnumMember(Value="SurfaceInteriorTemperature")]
        SurfaceInteriorTemperature = 8,
    }
}