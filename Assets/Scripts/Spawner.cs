using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject Enemy;
    public Vector3 spawnLocations; 
    // Start is called before the first frame update
    void Start()
    {
        Instantiate(Enemy, spawnLocations, Quaternion.identity);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
