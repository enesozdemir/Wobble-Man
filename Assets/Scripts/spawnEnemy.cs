using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using AmazingAssets.CurvedWorld;


public class spawnEnemy : MonoBehaviour
{
    
    public Transform spawnPoint;
    public GameObject boss, curved;
    public Camera bossCamera, mainCamera;

    // Start is called before the first frame update
    void Start()
    {
        bossCamera.enabled = false;
        mainCamera.enabled = true;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //GameObject.Find("Curved World Controller").GetComponent<CurvedWorldController>().SetBendVerticalSize(0f);
            Instantiate(boss, spawnPoint.position, spawnPoint.rotation);
            ForwardMovement.forwardSpeed = 3f;
            bossCamera.enabled = true;
            mainCamera.enabled = false;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //GameObject.Find("Curved World Controller").GetComponent<CurvedWorldController>().SetBendVerticalSize(6f);
            ForwardMovement.forwardSpeed = 10f;
            bossCamera.enabled = false;
            mainCamera.enabled = true;
        }
    }
}
