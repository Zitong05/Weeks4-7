using UnityEngine;

public class Ball : MonoBehaviour
{
    
    public static Ball CurrentBall;

    void OnEnable()
    {
        CurrentBall = this;
    }

    float gravity = 2.5f;
    Vector3 velocity;
    public float scoreValue = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dt = Time.deltaTime;

        velocity.y -= gravity * dt;

        transform.position += velocity * dt;

        scoreValue += Time.deltaTime;
    }

    public void AddForce(Vector3 force)
    {
        velocity += force;
    }

}
