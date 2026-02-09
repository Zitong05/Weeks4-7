using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class KnifeSpawner : MonoBehaviour
{
    public GameObject knifePrefab; // Reference to the knife prefab
    public GameObject Spawnedknife;
    Vector2 spawnPosition; // Position where the knives will be spawned
    Vector3 spawnRoation; // Rotation of the spawned knives
    public List<GameObject> Knives;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Vector3 newRotation = transform.eulerAngles; // Rotation of the spawned knives
        //newRotation.z = transform.position.z

        for (int i = 0; i < 5; i++)
        {
            spawnRoation.z = -90 + i * 45;
            spawnPosition.x = i -2;
            spawnPosition.y = -2 - (2-(Mathf.Abs(i-2)));
            Spawnedknife = Instantiate(knifePrefab, spawnPosition, Quaternion.Euler(spawnRoation));
            Knives.Add(Spawnedknife);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
