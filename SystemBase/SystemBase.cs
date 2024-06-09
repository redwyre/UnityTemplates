using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;

public partial class $fileinputname$ : SystemBase
{
    protected override void OnCreate()
    {
        RequireForUpdate<MyComponent>();
    }

    protected override void OnStartRunning()
    {
    }

    protected override void OnStopRunning()
    {
    }

    protected override void OnDestroy()
    {
    }

    protected override void OnUpdate()
    {
        foreach (var (myComponent, entity) in in SystemAPI.Query<RefRW<MyComponent>>().WithEntityAccess())
        {

        }

        var job = new MyJob
        {
        };

        job.ScheduleParallel();
    }
}
