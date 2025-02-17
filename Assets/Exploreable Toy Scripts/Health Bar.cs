using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public float health = 5;
    public Slider enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
        float clampedValue = Mathf.Clamp(health, 0f, 5f);
        enemyhealth.minValue = 0;
        enemyhealth.maxValue = health;
        enemyhealth.value = health;
    }

    // Update is called once per frame
    void Update()
    {
        //if ()
        //{
        //    TakeDamage(1)
        //}
    }

    public void TakeDamage(float damage)
    {
        health -= damage;
        enemyhealth.value = health;
    }
}
