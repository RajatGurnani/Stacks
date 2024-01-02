using UnityEngine;

public class Calculator : MonoBehaviour
{
    public Block prevBlock;
    public Block currentBlock;

    public void Start()
    {
        prevBlock = FindObjectsOfType<Block>()[0];
        currentBlock = BlockSpawner.Instance.SpawnBlock(Vector3.one);
    }

    public void OnDropBlock()
    {
        float distance = -prevBlock.transform.position.x + currentBlock.transform.position.x;
        float scaleSum = prevBlock.transform.localScale.x + currentBlock.transform.localScale.x;

        if (Mathf.Abs(distance) < scaleSum / 2)
        {
            float newScale = scaleSum / 2 - Mathf.Abs(distance);
            Vector3 scale = new Vector3(newScale, 1, 1);
            currentBlock.transform.localScale = scale;
            currentBlock.transform.position = new Vector3(prevBlock.transform.position.x + distance / 2, currentBlock.transform.position.y, currentBlock.transform.position.z);
            prevBlock = currentBlock;
            currentBlock = BlockSpawner.Instance.SpawnBlock(scale);
        }
    }

    public void OnEnable() => PlayerControl.DropBlock += OnDropBlock;

    private void OnDisable() => PlayerControl.DropBlock -= OnDropBlock;
}
