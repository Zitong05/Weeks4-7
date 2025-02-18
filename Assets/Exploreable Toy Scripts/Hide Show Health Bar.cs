using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HideShowHealthBar : MonoBehaviour
{
    
    private bool IsVisible = true;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SwitchVisibilityHealthBar()
    {
        
        IsVisible = !IsVisible;

        //looing for every health bar
        HealthBar[] healthBars = FindObjectsOfType<HealthBar>(true);

        // Switch the visibility of every health bar
        for (int i = 0; i < healthBars.Length; i++)
        {
            healthBars[i].gameObject.SetActive(IsVisible);
        }
    }
}
