using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ForwardMovement : MonoBehaviour
{
    //private CharacterController controller;
    private Vector3 direction;
    private Rigidbody rb;
    public static float forwardSpeed = 10f;

    // Start is called before the first frame update
    void Start()
    {
        //controller = GetComponent<CharacterController>();
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        //direction.z = forwardSpeed;
    }

    private void FixedUpdate()
    {
        //controller.Move(direction * Time.fixedDeltaTime);
        rb.MovePosition(transform.position + transform.forward * Time.fixedDeltaTime * forwardSpeed);
    }
    public void ReloadLevel()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
