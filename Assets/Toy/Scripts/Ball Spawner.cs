using System.Collections.Generic;
using UnityEngine;

public class BallSpawner : MonoBehaviour
{
    public GameObject ballPrefab;
    public GameObject spawnedBall;
    private Transform Ball;
    public List<GameObject> balls;
    

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnedBall = Instantiate(ballPrefab, new Vector3(0, 5, 0), Quaternion.identity);
        balls.Add(spawnedBall);
    }

    // Update is called once per frame
    void Update()
    {
        Ball = spawnedBall.transform;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(Ball.position);

        for (int i = 0; i < balls.Count; i++)
        {
            if (screenPos.y < 0)
            {

                Destroy(spawnedBall);
                balls.Remove(spawnedBall);
                spawnedBall = Instantiate(ballPrefab, new Vector3(0, 5, 0), Quaternion.identity);
                balls.Add(spawnedBall);
                
            }
        }
        
    }
}
