using System.Threading;
using UnityEngine;

public class DestoryFireworks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float fireworkTimer; 
    public float timeonScreen = 5; //determines how long the fireworks stays on screen
    public GameObject self; //refering to the fireworks themselves hennce 'itself'
    public FireworkSpawner fireworkSpawner;
   
    void Start()
    {
        fireworkTimer = 0; //just to make sure it resets 

    }


    // Update is called once per frame
    void Update()
    {
        fireworkTimer += Time.deltaTime;

        if (fireworkTimer >= timeonScreen)

        {
         
            fireworkSpawner.Countdown();
            Destroy(self);
            //after 5 seconds have passed, destroy myself (fireworks) and reduce the firework count by 1. 
            
        }
    }
}
