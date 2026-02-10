using NUnit.Framework;
using UnityEngine;
using UnityEngine.InputSystem;
using System.Collections.Generic;
public class FireworkSpawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public List<GameObject> FireworksPrefab;
    public GameObject spawnedFirework;
    public List<GameObject> fireworks;
    void Start()
    {
        
    }

    // Update is called once per frame


    public void Spawner()

    {   //instantiate a prefab: make a single firework appear for now
        //Instantiate(FireworksPrefab);
      

        fireworks.Add(spawnedFirework);

        Vector2 spawnPos = Random.insideUnitCircle * 4.5f;
        spawnedFirework = Instantiate(FireworksPrefab[(int)Random.Range(0,5)], spawnPos, transform.rotation);
        //Instantiate(FireworksPrefab, spawnPos, Quaternion.identity);

    }
}
