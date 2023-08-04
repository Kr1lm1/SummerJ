using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Mode1 : MonoBehaviour
{
    [SerializeField] GameObject bullet;

    private void Awake()
    {
        
    }

    private void Update()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
            {
                Instantiate(bullet, transform.position, Quaternion.identity);
            }
        }
    }
}
