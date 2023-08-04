using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class SpriteSorter : MonoBehaviour
{
    public bool isStatick = false;
    private int sortingOrderBase = 0;
    private Renderer render;
    [SerializeField] private float Offset;

    private void Awake()
    {
        render = GetComponent<Renderer>(); 
    }

    private void LateUpdate()
    {
        render.sortingOrder = (int)(sortingOrderBase - transform.position.y + Offset);

        if(isStatick)
        {
            Destroy(this);
        }
    }
}
