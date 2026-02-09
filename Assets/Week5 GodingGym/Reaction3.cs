using UnityEngine;

public class Reaction3 : MonoBehaviour
{
    public GameObject reaction;
    public Transform NPC;
    public float disToNpc;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        disToNpc = Vector3.Distance(transform.position, NPC.position);

        if (disToNpc < 2)
        {
            reaction.SetActive(true);
        }
        else
        {
            reaction.SetActive(false);
        }
    }
    
}
