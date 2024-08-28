using UnityEngine;

public class Gerak : MonoBehaviour
{
    Rigidbody2D rb;
    public float movementSpeed = 5f;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        if (rb == null)
        {
            Debug.LogError("No Rigidbody2D component found on this GameObject.");
        }
    }

    void Update()
    {
        // Get input from both horizontal (left/right) and vertical (up/down) axes
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");

        // Apply movement based on input
        rb.velocity = new Vector2(horizontal * movementSpeed, vertical * movementSpeed);

        // Debugging
        Debug.Log("Current Velocity: " + rb.velocity);
    }
}
