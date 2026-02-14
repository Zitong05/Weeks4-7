using UnityEngine;

public class BallGravity : MonoBehaviour
{
    float gravity = -9.81f; // Gravity
    Vector3 velocity; // Current velocity of the ball

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
        velocity.y += gravity * Time.deltaTime; // Apply gravity to the vertical velocity
        transform.position += velocity *  Time.deltaTime; // Move the ball based on its velocity

    }
}
