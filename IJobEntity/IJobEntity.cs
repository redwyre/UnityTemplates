using Unity.Burst;
using Unity.Collections;
using Unity.Core;
using Unity.Entities;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Transforms;

[BurstCompile]
public partial struct $safeitemrootname$ : IJobEntity
{
    public void Execute([ChunkIndexInQuery] int chunkIndexInQuery, [EntityIndexInChunk] int entityIndexInChunk, [EntityIndexInQuery] int entityIndexInQuery, in LocalTransform localTransform, Entity entity)
    {
    }
}
