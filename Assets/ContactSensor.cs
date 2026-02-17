using UnityEngine;
using UnityEngine.Events;

public class ContactSensor : MonoBehaviour

  
{

    public SpriteRenderer hazard;
    public bool isHazard = false;
    public UnityEvent OnEnterHazard;
    public UnityEvent OnExitHazard;

    public UnityEvent<float> OnRandomNumber;

    void Start()
    {
        
    }


    void Update()
    {
        //is the player inside the hazard sprite?
        if(hazard.bounds.Contains(transform.position) == true)

        {
            if (isHazard == true)
            {

            }
            else
            {
                //just entered the hazard! do something
                //Y: player has tripped the sensor 
                Debug.Log("Entered the hazardd!");
                isHazard = true;
                OnEnterHazard.Invoke();
            }
            //Y: player has tripped the sensor 
        }

        else
        {
            if (isHazard == true)
            {
                //we just left the hazard 
                //N: player has not tripped the sensor 

                isHazard = false;
                Debug.Log("Exit the hazard!");
                OnEnterHazard.Invoke();
                OnRandomNumber.Invoke(Random.Range(0,10));
            }
            else
            {
                //we're still not in the hazard 
            }
        }


    }

    public void ShowNumber(float number)
    {
        Debug.Log(number);
    }
}
