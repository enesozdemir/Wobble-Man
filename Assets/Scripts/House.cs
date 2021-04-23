using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class House : MonoBehaviour
{
    public GameObject gameOverPanel;
    // Start is called before the first frame update
    void Start()
    {
        gameOverPanel = GameObject.Find("Canvas").transform.Find("GameOverPanel").gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Target")
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }
}
