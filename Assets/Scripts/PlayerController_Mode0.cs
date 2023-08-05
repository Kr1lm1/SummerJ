using UnityEngine;

public class PlayerController_Mode0 : MonoBehaviour
{
    [SerializeField] private float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    [SerializeField] private Animator Anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        Anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 0)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");

            Anim.SetFloat("Horizontal", direction.x);
            Anim.SetFloat("Vertical", direction.y);
            Anim.SetFloat("Speed", direction.sqrMagnitude);
        }
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
    }
}
