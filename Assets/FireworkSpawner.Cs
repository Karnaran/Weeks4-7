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

        //instantiate a prefab: make a single firework appear for now
        //Instantiate(FireworksPrefab);


        fireworks.Add(spawnedFirework);

        Vector2 spawnPos = Random.insideUnitCircle * 5f;
        spawnedFirework = Instantiate(FireworksPrefab[(int)Random.Range(0,5)], spawnPos, transform.rotation); //randomly picks a firework to display between 0-4 range.
        //Instantiate(FireworksPrefab, spawnPos, Quaternion.identity);

    }

    public void SetScaleBig(float scale)

    {
        spawnedFirework.transform.localScale = Vector3.one * scale * scaleMultiply; //enlarges the images as per the slider
        //slider increased by one as the image gets larger, once it reaches it's size, made it capable of retaining its orignal form if the user sizes it down
    }
    public void SetRotation(float rotate)

    {
        float y = 0;
        RotationANngle = new Vector3(0,0 ,36)  * rotate;
        spawnedFirework.transform.localRotation = Quaternion.Euler(RotationANngle); //creates rotate in degrees. Euler angles in degrees to a Quaternion
    }



    public void CountUp()

    {
        fireworksetofCount++;
        FireworkCount.text = fireworksetofCount.ToString();

        
    }
}
