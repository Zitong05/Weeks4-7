using UnityEngine;
using static UnityEngine.Rendering.DebugUI;

public class BowMovement : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveBowL(float t)
    {
        Vector3 currentPos = transform.position;

        Vector3 newPos = new Vector3(-t,currentPos.y,currentPos.z);
        transform.position = newPos;
    }

    public void MoveBowR(float t)
    {
        Vector3 currentPos = transform.position;
        Vector3 newPos = new Vector3(t, currentPos.y, currentPos.z);
        transform.position = newPos;

    }
}
