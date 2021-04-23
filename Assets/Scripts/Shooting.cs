using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    [SerializeField]
    GameObject bullet, spawnLocation, WinPanel;

    private void Start()
    {
        WinPanel = GameObject.Find("Canvas").transform.Find("WinPanel").gameObject;
    }
    


    public void Fire()
    {
        Instantiate(bullet, spawnLocation.transform.position, Quaternion.identity);

    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {            
            WinPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
