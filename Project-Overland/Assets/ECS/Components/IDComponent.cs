using Unity.Entities;
using Unity.Mathematics;
using Unity.Physics;
using Unity.Transforms;
using UnityEngine;

// ID component to uniquely identify an entity
public struct ID : IComponentData
{
    public int Value;
}