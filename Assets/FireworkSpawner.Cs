using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SocialPlatforms.Impl;

public class FireworkSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<GameObject> FireworksPrefab;
    public GameObject spawnedFirework;
    public List<GameObject> fireworks;
    public Slider slider;
    Vector3 RotationANngle;
    public int fireworksetofCount = 0;
    public float scaleMultiply = 0.5f;
    public TextMeshProUGUI FireworkCount;
    void Start()
    {


    }

    // Update is called once per frame


    public void Spawner()


    {
        
        FireworkCount.text = fireworksetofCount.ToString();
        slider.wholeNumbers = true;

        FireworkCount.text = slider.value.ToString();

    

        fireworks.Add(spawnedFirework);

        Vector2 spawnPos = Random.insideUnitCircle * 5f;
        spawnedFirework = Instantiate(FireworksPrefab[(int)Random.Range(0,5)], spawnPos, transform.rotation); //randomly picks a firework to display between 0-4 range.
        spawnedFirework.GetComponent<DestoryFireworks>().fireworkSpawner = GetComponent<FireworkSpawner>(); 
        //fills in the empty vessel of FireworkSpawner using itself so it can be applied and used in DestoryFireworks
      

    }

    public void SetScaleBig(float scale)

    {
        spawnedFirework.transform.localScale = Vector3.one * scale * scaleMultiply; //enlarges the images as per the slider
        //slider increased by one as the image gets larger, once it reaches it's size it has been made capable of retaining its orignal form if the user sizes it down rather than vanishing entirely off the screen
    }
    public void SetRotation(float rotate)

    {
        //float y = 0;
        RotationANngle = new Vector3(0,0 ,36)  * rotate; //using Z as rotation to give the illusion of the firework image moving sideways on the screen as the user plays around the rotate
        spawnedFirework.transform.localRotation = Quaternion.Euler(RotationANngle); //creates rotate in degrees. Euler angles in degrees to a Quaternion
    }



    public void CountUp()

    {
        fireworksetofCount++;
        FireworkCount.text = fireworksetofCount.ToString(); //adds the times fireworks are dispalyed on screen 

    
    }


    public void Countdown()

    {
        fireworksetofCount--;
        FireworkCount.text = fireworksetofCount.ToString(); //subtracts the times firworks are displayed on screen after each firework destroys itself. 
    }

}
