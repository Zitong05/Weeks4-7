using UnityEngine;

public class ArrowSpawner : MonoBehaviour
{
    public GameObject arrowPrefab; // Prefab of the arrow to spawn


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SpawnArrow()
    {
        Instantiate(arrowPrefab, transform.position, transform.rotation); // Spawn the arrow at the spawner's position and rotation
    }
}
