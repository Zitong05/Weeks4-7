using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer hazard;
    public bool isInHazard = false;
    public UnityEvent OnEnterSensor;
    public UnityEvent OnExitSensor;
    public UnityEvent<float> OnRandomNumber;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hazard.bounds.Contains(transform.position) == true)
        {
            if (isInHazard == true)
            {
                //still in the hazard
            }
            else
            {
                OnEnterSensor.Invoke();
                isInHazard = true;
            }
        }
        else
        {
            if (isInHazard == true)
            {
                OnExitSensor.Invoke();
                isInHazard = false;
                OnRandomNumber.Invoke(Random.Range(0, 10));
            }
            else 
            { 
                //still outside the hazard
            }
            
        }
            
    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
