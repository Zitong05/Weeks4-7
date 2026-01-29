using UnityEngine;
using UnityEngine.InputSystem;

public class TankSpawner : MonoBehaviour
{
    public GameObject tankPrefab;
    public int howManyTanks = 0;
    public GameObject spawnerTank;

    public FirstScript tankScript;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame == true)
        {
            spawnerTank = Instantiate(tankPrefab, transform.position, transform.rotation);

            tankScript = spawnerTank.GetComponent<FirstScript>();

            howManyTanks += 1;
        }     
    }
}
