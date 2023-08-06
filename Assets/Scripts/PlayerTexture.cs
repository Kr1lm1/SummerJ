using UnityEngine;

public class PlayerTexture : MonoBehaviour
{
    [SerializeField] private Sprite Left;
    [SerializeField] private Sprite Right;
    [SerializeField] private Sprite Up;
    [SerializeField] private Sprite Down;

    void Update()
    {
        if (Input.GetKeyDown("a"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Left;  
        }
        else if (Input.GetKeyDown("d"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Right;
        }
        else if (Input.GetKeyDown("w"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Up;
        }
        else if (Input.GetKeyDown("s"))
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = Down;
        }
    }
}
