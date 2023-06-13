using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// Color component to store the color of an entity
public struct Color : IComponentData
{
    public float4 Value;
}