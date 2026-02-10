using NUnit.Framework;
using UnityEngine;
using System.Collections.Generic;

public class Barrel : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int Knivesamount = 0;
    public GameObject spawnedKnives;
    public GameObject Knifeprefab;
    public List<GameObject> Knives;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        spawnedKnives = Instantiate(Knifeprefab, transform.position,transform.rotation);
    }

    public void Knife()

        
    {
        Instantiate(Knifeprefab, transform);
        Vector2 spawnPos = Random.insideUnitCircle * 1;
        Knives.Add(spawnedKnives);

        Knivesamount += 1;

    }    

}
