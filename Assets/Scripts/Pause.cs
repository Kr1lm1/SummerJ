using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    [SerializeField] private GameObject PausePanel;

    public void PauseOn()
    {
        Time.timeScale = 0f;
        PausePanel.SetActive(true);
    }
    public void PauseOff()
    {
        Time.timeScale = 1f;
        PausePanel.SetActive(false);
    }
}
