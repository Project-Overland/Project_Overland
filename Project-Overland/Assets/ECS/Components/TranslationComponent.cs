using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;

// Define the Translation component
public struct Translation : IComponentData
{
    public float3 Value;
}
