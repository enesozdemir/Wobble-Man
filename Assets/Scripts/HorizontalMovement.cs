using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class HorizontalMovement : MonoBehaviour
{

    public float speed = 1f;
    public float rotateSpeed = 1f;
    float rotation = 0;
    

    // Update is called once per frame
    void Update()
    {

        // Hacýyatmaz sag-sol yatýrma
        if (CrossPlatformInputManager.GetAxis("Horizontal")>0)
        {
            
            rotation += rotateSpeed * Time.deltaTime;
           rotation = Mathf.Clamp(rotation, -70, 70);
            GetComponent<DynamicBone>().enabled = false;
        }

        else if (CrossPlatformInputManager.GetAxis("Horizontal") < 0)
        {
            rotation -= rotateSpeed * Time.deltaTime;
            rotation = Mathf.Clamp(rotation, -70, 70);
            GetComponent<DynamicBone>().enabled = false;
        }
        else
        {
            rotation = Mathf.LerpAngle(rotation, 0, 10 * Time.deltaTime);
            GetComponent<DynamicBone>().enabled = true;
        }

        transform.rotation = Quaternion.Euler(0, 0, rotation);

    }
  

}
