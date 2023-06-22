using System;
using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Transforms;
using UnityEngine;

[BurstCompile]
public partial struct $fileinputname$System : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<$fileinputname$>();
    }

    public void OnDestroy(ref SystemState state)
    {
    }

    public void OnUpdate(ref SystemState state)
    {
        var job = new $fileinputname$Job
        {
        };
        job.ScheduleParallel();
    }

    [BurstCompile]
    public partial struct $fileinputname$Job : IJobEntity
    {
        void Execute(
            Entity entity,
            [ChunkIndexInQuery] int chunkIndexInQuery,
            [EntityIndexInChunk] int entityIndexInChunk,
            [EntityIndexInQuery] int entityIndexInQuery,
            in LocalTransform localTransform,
            ref $fileinputname$ my$fileinputname$)
        {
        }
    }
}
