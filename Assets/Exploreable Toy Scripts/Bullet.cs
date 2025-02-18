using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 0.05f;
    public float damage = 1;
    // Start is called before the first frame update
    void Start()
    {
        // Destroy bullet in 3s
        Destroy(gameObject, 3);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;

        pos.x = speed;

        transform.position += transform.right * -speed;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // chech if bullet hit enemy
        if (collision.CompareTag("Enemy"))
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if (enemy != null)
            {
                enemy.TakeDamage(1);
            }

            // Destroy bullet when hit enemy
            Destroy(gameObject);
        }
    }
}
