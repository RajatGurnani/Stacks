using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockSpawner : Singleton<BlockSpawner>
{
    public Block blockPrefab;
    public Vector3 baseOffset = new Vector3(-2f, 0.1f, 0f);
    public int count = 0;

    public override void Awake()
    {
        base.Awake();
        name = nameof(BlockSpawner);
    }

    public Block SpawnBlock(Vector3 scale)
    {
        count++;
        Block block = Instantiate(blockPrefab, Vector3.Scale(baseOffset, new Vector3(1, count, 1)), Quaternion.identity);
        block.transform.localScale = scale;
        block.StartMoving();
        return block;
    }
}
