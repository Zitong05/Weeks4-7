using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    
    public float speed = 0.01f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = speed;
        
        
        transform.position += transform.right * -speed;


        //Vector3 mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //mouse.z = 0;
        //Vector2 directon = mouse - transform.position;

        //transform.right = -directon * speed;
    }

}
