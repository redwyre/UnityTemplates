using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

public class $fileinputname$Authoring : MonoBehaviour
{
    public int Value;

    public class Baker : Baker<$fileinputname$Authoring>
    {
        public override void Bake($fileinputname$Authoring authoring)
        {
            var entity = GetEntity(TransformUsageFlags.Dynamic);
            AddComponent(entity, new $fileinputname$
            {
                Value = authoring.Value
            });
        }
    }
}