using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Slider enemyhealth;
    // Start is called before the first frame update
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
       
    }
    public void SetMaxHealth(int health)
    {
        enemyhealth.maxValue = health;
        enemyhealth.value = health;
    }

    // 设置当前血量
    public void SetHealth(int health)
    {
        enemyhealth.value = health;
    }
}
