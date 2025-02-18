using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{
    public Vector2 playerPos;
    int playerSpeed;
    float t;
    AnimationCurve jCurve;
    // Start is called before the first frame update
    void Start()
    {
        playerPos = new Vector2(0, 0);
        playerSpeed = 5;
    }

    // Update is called once per frame
    void Update()
    {

        playerPos.x = playerPos.x + (Input.GetAxis("Horizontal")) * playerSpeed * Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            //start timer
            jCurve.Evaluate(t);
        }
        if (playerPos.y >= 1)
        {
            t = 0;
        }
        transform.position = playerPos;
    }
}
