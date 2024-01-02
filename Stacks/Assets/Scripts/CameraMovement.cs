using UnityEngine;
using PrimeTween;

public class CameraMovement : MonoBehaviour
{
    public float moveAmount =0.1f;

    private void Start()
    {
        moveAmount = FindFirstObjectByType<BlockSpawner>().baseOffset.y;
    }

    public void Move()
    {
        Tween.PositionY(transform, transform.position.y + moveAmount, 2f);
    }

    private void OnEnable()
    {
        PlayerControl.DropBlock += Move;
    }

    private void OnDisable()
    {
        PlayerControl.DropBlock -= Move;
    }
}
