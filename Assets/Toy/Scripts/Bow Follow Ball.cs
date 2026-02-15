using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BowFollowBall : MonoBehaviour
{
    public BallSpawner ballSpawner;
    public Transform ball;
    Vector3 direction;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 Ball = ballSpawner.spawnedBall.transform.position;
        direction = Ball - transform.position;
        transform.up = direction;
    }
}
