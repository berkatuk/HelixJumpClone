using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class HelixManager : MonoBehaviour
{
    public GameObject[] rings;
    public float noOfRings = 10f;
    public float ringDistance = 5;
    private float yPos;


    private void Start()
    {
        for (int i = 0; i < noOfRings; i++)
        {
            if (i==0)
            {
                SpawnRing(0);
            }
            else
            {
                SpawnRing(Random.Range(1, rings.Length - 1));
            }
        }
        SpawnRing(rings.Length-1);
    }

    void SpawnRing(int index)
    {
        GameObject newRing = Instantiate(rings[index],
            new Vector3(transform.position.x, yPos, transform.position.z), Quaternion.identity);
        yPos -= ringDistance;
        newRing.transform.parent = transform;
    }
    
    
}

