using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_movement : MonoBehaviour
{
    // Adds movement
    public Rigidbody rb;
    public float Forward_Force = 1000f;
    public float Sideway_Force = 100f;

    // Update is called once per frame
    void FixedUpdate()
    {
        // Adds forward force
        if (Input.GetKey("w"))
        {
            rb.AddForce(0, 0, Forward_Force * Time.deltaTime);
        }
        // right movement
        if (Input.GetKey("d")) 
        {
            rb.AddForce(Sideway_Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        // Left movement
        if (Input.GetKey("a"))
        {
            rb.AddForce(-Sideway_Force * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }



    }
}
