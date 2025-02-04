using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Reaction1 : MonoBehaviour
{
    public float speed = 0.005f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        
        if(Input.GetKey(KeyCode.W))
        {
            pos.y += speed;
        }

        if (Input.GetKey(KeyCode.S))
        {
            pos.y -= speed;
        }

        if (Input.GetKey(KeyCode.A))
        {
            pos.x -= speed;
        }

        if (Input.GetKey(KeyCode.D))
        {
            pos.x += speed;
        }

        transform.position = pos;
    }
}
