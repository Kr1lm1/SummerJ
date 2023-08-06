using UnityEngine;

public class PlayerTexture : MonoBehaviour
{
    [SerializeField] private Sprite Left;
    [SerializeField] private Sprite Right;
    [SerializeField] private Sprite Up;
    [SerializeField] private Sprite Down;
    [SerializeField] private GameObject Arms;
    [SerializeField] private GameObject NArm;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Left;
            NArm.SetActive(true);
            Arms.SetActive(false);   
        }
        else if (Input.GetKeyDown("d"))
        {
            NArm.SetActive(true);
            Arms.SetActive(false);
            gameObject.GetComponent<SpriteRenderer>().sprite = Right;
        }
        else if (Input.GetKeyDown("w"))
        {
            NArm.SetActive(false);
            Arms.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = Up;
        }
        else if (Input.GetKeyDown("s"))
        {
            NArm.SetActive(false);
            Arms.SetActive(true);
            gameObject.GetComponent<SpriteRenderer>().sprite = Down;
        }
    }
}
