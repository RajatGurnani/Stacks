using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Block : MonoBehaviour
{
    public float moveSpeed;

    public Vector3 moveDirection = Vector3.right;
    public bool isMoving = false;
    public bool isPlaced = false;

    private void Update()
    {
        if (isMoving)
        {
            transform.Translate(moveDirection * moveSpeed * Time.deltaTime);
        }
    }
    public void StartMoving()
    {
        if (!isPlaced)
        {
            isMoving = true;
        }
    }

    public void StopMoving()
    {
        if (!isPlaced)
        {
            isPlaced = true;
            isMoving = false;
        }
    }

    public void SetPosition(Vector3 position) => transform.position = position;

    public void SetScale(Vector3 scale) => transform.localScale = scale;

    private void OnEnable() => PlayerControl.DropBlock += StopMoving;

    private void OnDisable() => PlayerControl.DropBlock -= StopMoving;
}
