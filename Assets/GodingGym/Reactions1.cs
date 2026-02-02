using UnityEngine;
using UnityEngine.InputSystem;

public class Reactions1 : MonoBehaviour
{
    
    float playerSpeed = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPosition = transform.position;

        if (Keyboard.current.aKey.isPressed)
        {
            newPosition.x -= playerSpeed * Time.deltaTime;
        }
        if (Keyboard.current.dKey.isPressed)
        {
            newPosition.x += playerSpeed * Time.deltaTime;
        }
        if (Keyboard.current.wKey.isPressed)
        {
            newPosition.y += playerSpeed * Time.deltaTime;
        }
        if (Keyboard.current.sKey.isPressed)
        {
            newPosition.y -= playerSpeed * Time.deltaTime;
        }

        transform.position = newPosition;
    }
}
