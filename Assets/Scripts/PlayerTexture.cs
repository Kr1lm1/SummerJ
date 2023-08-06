using UnityEngine;

public class PlayerTexture : MonoBehaviour
{
    [SerializeField] private Sprite Left;
    [SerializeField] private Sprite Up;
    [SerializeField] private Sprite Down;

    [SerializeField] private Sprite LeftTurelSprite;
    [SerializeField] private Sprite UpTurelSprite;
    [SerializeField] private Sprite DownTurelSprite;

    [SerializeField] private GameObject Arms;
    [SerializeField] private GameObject TurelButtons;

    void Update()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 0)
        {
            if (Input.GetKeyDown("a") || Input.GetKeyDown("left"))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Left;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                Arms.SetActive(false);
                TurelButtons.SetActive(false);
            }
            else if (Input.GetKeyDown("d") || Input.GetKeyDown("right"))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Left;
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
                Arms.SetActive(false);
                TurelButtons.SetActive(false);
            }
            else if (Input.GetKeyDown("w") || Input.GetKeyDown("up"))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Up;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                Arms.SetActive(true);
                TurelButtons.SetActive(false);
            }
            else if (Input.GetKeyDown("s") || Input.GetKeyDown("down"))
            {
                gameObject.GetComponent<SpriteRenderer>().sprite = Down;
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
                Arms.SetActive(true);
                TurelButtons.SetActive(false);
            }
        }
        else if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            TurelButtons.SetActive(true);
        }
    }

    public void LeftTurel()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = LeftTurelSprite;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Arms.SetActive(false);
        }
    }
    public void RightTurel()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = LeftTurelSprite;
            gameObject.GetComponent<SpriteRenderer>().flipX = true;
            Arms.SetActive(false);
        }
    }
    public void DownTurel()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = DownTurelSprite;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Arms.SetActive(false);
        }
    }
    public void UpTurel()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 1)
        {
            gameObject.GetComponent<SpriteRenderer>().sprite = UpTurelSprite;
            gameObject.GetComponent<SpriteRenderer>().flipX = false;
            Arms.SetActive(false);
        }
    }
}
