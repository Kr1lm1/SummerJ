using UnityEngine;

public class PlayerController_Mode0 : MonoBehaviour
{
    public float speed;
    private Rigidbody2D rb;
    private Vector2 direction;
    public Animator Anim;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 0)
        {
            direction.x = Input.GetAxisRaw("Horizontal");
            direction.y = Input.GetAxisRaw("Vertical");
            rb.MovePosition(rb.position + direction * speed * Time.fixedDeltaTime);
        }
    }
}
