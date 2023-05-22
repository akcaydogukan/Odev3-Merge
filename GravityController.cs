using UnityEngine;

public class FishMovement : MonoBehaviour
{
    public float gravity = 9.8f;
    public float jumpForce = 5f;

    private Rigidbody2D rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        // Yerçekimi uygula
        rb.AddForce(Vector2.down * gravity * rb.mass);

        // Space tuşuna basıldığında zıplama
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
