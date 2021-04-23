using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
    public GameObject Player, gameOverPanel;
    Rigidbody r;
    public float speed = 25f;
    

    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
        gameOverPanel = GameObject.Find("Canvas").transform.Find("GameOverPanel").gameObject;
        Player = GameObject.FindWithTag("Player");
        r = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        r.velocity=new Vector3(0,0,-speed) * Time.deltaTime;
        if (transform.position.z < Player.transform.position.z)
        {
            gameOverPanel.SetActive(true);
            Time.timeScale = 0;
        }
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Player" || col.gameObject.tag == "Enemy")
        {
            r.constraints = RigidbodyConstraints.None;
            Destroy(GetComponent<Enemy>());
        }
    }
}
