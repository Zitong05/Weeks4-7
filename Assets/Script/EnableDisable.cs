using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableDisable : MonoBehaviour
{
    public GameObject go;
    public SpriteRenderer sr;
    public EnableDisable script;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            sr.enabled = false;
            go.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.enabled = true;
            go.SetActive(true);
        }
    }
}
