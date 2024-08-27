using UnityEngine;

public class Gerak : MonoBehaviour
{
    public float movementSpeed = 5f;

    void Update()
    {
        // Read horizontal input
        float horizontal = Input.GetAxisRaw("Horizontal");

        // Debugging
        Debug.Log("Horizontal Input: " + horizontal);

        // Move the GameObject based on input
        transform.Translate(new Vector2(horizontal * movementSpeed * Time.deltaTime, 0));
    }
}
