using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerTransformation : MonoBehaviour
{
    public float PlayerMode = 0f;

    private void Update()
    {
        if (Input.GetKeyDown("e"))
        {
            if (PlayerMode == 0)
            {
                PlayerMode = 1;
            }
            else
            {
                PlayerMode = 0;
            }
        }
    }
}
