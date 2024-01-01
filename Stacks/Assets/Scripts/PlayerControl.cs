using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public static event System.Action DropBlock;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            DropBlock();
        }
    }
}
