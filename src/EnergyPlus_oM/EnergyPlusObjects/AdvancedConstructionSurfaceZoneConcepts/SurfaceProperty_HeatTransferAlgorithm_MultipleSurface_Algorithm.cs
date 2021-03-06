namespace BH.oM.Adapters.EnergyPlus.AdvancedConstructionSurfaceZoneConcepts
{
    public enum SurfaceProperty_HeatTransferAlgorithm_MultipleSurface_Algorithm
    {
        
        [System.Runtime.Serialization.EnumMember(Value="")]
        Empty = 0,
        
        [System.Runtime.Serialization.EnumMember(Value="CombinedHeatAndMoistureFiniteElement")]
        CombinedHeatAndMoistureFiniteElement = 1,
        
        [System.Runtime.Serialization.EnumMember(Value="ConductionFiniteDifference")]
        ConductionFiniteDifference = 2,
        
        [System.Runtime.Serialization.EnumMember(Value="ConductionTransferFunction")]
        ConductionTransferFunction = 3,
        
        [System.Runtime.Serialization.EnumMember(Value="MoisturePenetrationDepthConductionTransferFunction")]
        MoisturePenetrationDepthConductionTransferFunction = 4,
    }
}