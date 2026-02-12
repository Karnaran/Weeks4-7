using System.Threading;
using UnityEngine;

public class DestoryFireworks : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public float fireworkTimer;
    public float timeonScreen = 5;
    public GameObject self;
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
            fireworkSpawner.fireworksetofCount--;
            Destroy(self);
            //after 5 seconds have passed, destroy myself (fireworks) and reduce the firework count by 1. 
            //I can't reduce the timer because it doesn't see fireworksetofCount
            //I need help finding get the component from the other script on each firework prefab 
        }
    }
}
