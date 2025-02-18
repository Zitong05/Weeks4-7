using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Enemy : MonoBehaviour
{
    public float speed = 5;
    public int health = 5;
    public int maxHealth = 5;

    public HealthBar HealthBar;

    // Start is called before the first frame update
    void Start()
    {
        //initial health
        float clampedValue = Mathf.Clamp(health, 0f, 5f);
        health = maxHealth;
        HealthBar.SetMaxHealth(maxHealth);
    }

    // Update is called once per frame
    void Update()
    {
        //movement
        Vector3 pos = transform.position;
        pos.x += speed * Time.deltaTime;

        Vector2 screenPos = Camera.main.WorldToScreenPoint(pos);

        if (screenPos.x<0 || screenPos.x > Screen.width)
        {
            speed = speed * -1;
        }
        transform.position = pos;
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        HealthBar.SetHealth(health);

        if (health <= 0)
        {
            Die();
        }
    }

    void Die()
    {
        Destroy(gameObject);
    }

}
