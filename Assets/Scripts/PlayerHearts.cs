using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHearts : MonoBehaviour
{
    [SerializeField] private GameObject Heart;
    [SerializeField] private GameObject Heart1;
    [SerializeField] private GameObject Heart2;
    [SerializeField] private GameObject DeadPanel;
    [SerializeField] private GameObject GamePanel;
    [SerializeField] private GameObject PausePanel;

    private float hearts = 3f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy")
        {
            hearts--;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.tag == "Map")
        {
            hearts = 0;
        }
    }

    private void FixedUpdate()
    {
        if (hearts == 3)
        {
            Heart.SetActive(true);
            Heart1.SetActive(true);
            Heart2.SetActive(true);
        }
        else if (hearts == 2)
        {
            Heart.SetActive(true);
            Heart1.SetActive(true);
            Heart2.SetActive(false);
        }
        else if (hearts == 1)
        {
            Heart.SetActive(true);
            Heart1.SetActive(false);
            Heart2.SetActive(false);
        }
        else if (hearts == 0)
        {
            Heart.SetActive(false);
            Heart1.SetActive(false);
            Heart2.SetActive(false);

            DeadPanel.SetActive(true);
            GamePanel.SetActive(false);
            PausePanel.SetActive(false);

            Time.timeScale = 0f;
        }
    }
}
