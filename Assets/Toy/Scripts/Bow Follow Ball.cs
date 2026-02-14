using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BowFollowBall : MonoBehaviour
{
    public Transform ball;
    Vector3 direction;
    Vector3 bowPosition;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        direction = ball.position - transform.position;
        transform.up = direction;
    }
}
