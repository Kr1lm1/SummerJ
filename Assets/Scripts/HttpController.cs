using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HttpController : MonoBehaviour
{
    [SerializeField] string URL;
    
    public void Http()
    {
        Application.OpenURL(URL);
    }
}
