using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.UIElements;

public class Clockchimes : MonoBehaviour
{
    float speed = -0.005f;
    public AudioSource audioSource;
    public AudioClip clip;
    float scale = 30;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 rot = transform.eulerAngles;
        rot.z += speed;
        transform.eulerAngles = rot;

        
        if(rot.z % scale == 0)
        {
            for (int i = 0; i < 12; i++)
            {               
                audioSource.Play((ulong)i*5);
                audioSource.PlayOneShot(clip);
            }          
        }
    }
}
