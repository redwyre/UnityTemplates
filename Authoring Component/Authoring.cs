using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class $fileinputname$ : MonoBehaviour
{
    public int Value;

    public class Baker : Baker<$fileinputname$>
    {
        public override void Bake($fileinputname$ authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new MyComponent
            {
                Value = authoring.Value
            });
        }
    }
}