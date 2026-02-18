using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour
{
    public SpriteRenderer pushable;
    public bool isPush = false;
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
        Vector3 direction = pushable.transform.position - transform.position;

        if (pushable.bounds.Contains(transform.position) == true)
        {
            if (isPush == true)
            {
                //still pushing
            }
            else
            {
                OnEnterSensor.Invoke();
                
                pushable.transform.position += direction;
            }
        }
        else
        {
            if (isPush == true)
            {
                OnExitSensor.Invoke();
                isPush = false;
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
