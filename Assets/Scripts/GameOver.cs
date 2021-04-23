using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;

    public void PlayGame()
    {
        gameOverPanel.SetActive(false);
        GameObject.FindWithTag("Player").GetComponent<ForwardMovement>().ReloadLevel();
    }

    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.tag == "Enemy")
    //    {
    //        gameOverPanel.SetActive(true);
    //        Time.timeScale = 0;
    //    }
    //}
}
