using UnityEngine;

public class Toggle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    public void ToggleBird()
    {
        Debug.Log("Toggle the bird please");
        //gameObject.SetActive(false);
        //gameObject.activeInHierarchy

        //if the bird is active, call SetActive and pass false
        if (gameObject.activeInHierarchy == true)
        {
            gameObject.SetActive(false);
        }
        else if (gameObject.activeInHierarchy == false)
        {
            gameObject.SetActive(true);
        }
        //if the bird is active, call SetActive 
        //otherwise if the bird is not active, call SetActive and pass true

        //gameObject.SetActive(!gameObject.activeInHierarchy);
    }
}
