using UnityEngine;

public class PlayerController_Mode0 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    [SerializeField] private float _time;
    [SerializeField] private float _NormalTime;
    [SerializeField] private GameObject Heart;
    [SerializeField] private GameObject Heart1;
    [SerializeField] private GameObject Heart2;
    [SerializeField] private GameObject DeadPanel;
    [SerializeField] private GameObject GamePanel;
    [SerializeField] private GameObject PausePanel;

    private float hearts = 3f;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 0)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        _time -= Time.fixedDeltaTime;

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
    private void OnTriggerStay(Collider other)
    {
        if (other.tag == "Enemy")
        {
            if (_time <= 0)
            {
                hearts--;
                _time = _NormalTime;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.tag == "Map")
        {
            hearts = 0;
        }
    }
}
