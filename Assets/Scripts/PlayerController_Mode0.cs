using UnityEngine;

public class PlayerController_Mode0 : MonoBehaviour
{
    public float speed = 5f;
    
    private Rigidbody2D rb;
    private Vector2 movement;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        if (gameObject.GetComponent<PlayerTransformation>().PlayerMode == 0)
        {
            float horizontalInput = Input.GetAxisRaw("Horizontal");
            float verticalInput = Input.GetAxisRaw("Vertical");

            movement = new Vector2(horizontalInput, verticalInput).normalized;

            rb.MovePosition(rb.position + movement * speed * Time.fixedDeltaTime);
        }
    }
}
