using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Bullet : MonoBehaviour
{
    PlayerPose target;
    Rigidbody rb;
    Vector3 moveDirection;
    public float travelDistance = 500f;
    public float moveSpeed;
    public GameObject gameOverPanel;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        target = GameObject.FindObjectOfType<PlayerPose>();
        moveDirection = (target.transform.position - transform.position).normalized * moveSpeed;
        rb.velocity = new Vector3(moveDirection.x, moveDirection.y, moveDirection.z);
        gameOverPanel = GameObject.Find("Canvas").transform.Find("GameOverPanel").gameObject;
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
