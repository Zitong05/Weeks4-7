using UnityEngine;
using UnityEngine.SceneManagement;

public class Arrow : MonoBehaviour
{

    float lifetime = 2f; // Lifetime of the arrow in seconds
    float speed = 50f; // Speed of the arrow
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = transform.position + transform.up * speed * Time.deltaTime; // Move the arrow forward
        transform.position = newPos;
        Destroy(gameObject, lifetime); // Destroy the arrow after its lifetime expires

        CheckDistance();
    }

    void CheckDistance()
    {
        if (Ball.CurrentBall == null) return;

        Transform ballTransform = Ball.CurrentBall.transform;

        float distance = Vector3.Distance(transform.position, ballTransform.position);

        if (distance < 1)
        {
            
            Vector3 direction = (ballTransform.position - transform.position).normalized;

            Vector3 impulse = direction * 3;

            Ball.CurrentBall.AddForce(impulse);

            Destroy(gameObject);

            if (Score.Instance != null)
            {
                Score.Instance.AddScore(1);
            }
                
        }
    }

}
