using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;

[BurstCompile]
public partial struct $fileinputname$ : ISystem
{
    public void OnCreate(ref SystemState state)
    {
        state.RequireForUpdate<MyComponent>();
    }

    public void OnDestroy(ref SystemState state)
    {
    }

    public void OnUpdate(ref SystemState state)
    {
        var job = new MyJob
        {
        };

        job.ScheduleParallel();
    }
}
