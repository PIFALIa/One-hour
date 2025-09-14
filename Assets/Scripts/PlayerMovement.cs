using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerMovementDIO : MonoBehaviour
{
    public float Movespeed = 1f;
    public float JumpScale = 1f;
    public Rigidbody rb;
    public bool isJump;

    void Jump()
    {
        rb.velocity = new Vector3(0, JumpScale, 0);
    }
    
    void FixedUpdate()
    {
       float h = Input.GetAxis("Horizontal") * Movespeed * Time.deltaTime;
       float v = Input.GetAxis("Vertical") * Movespeed * Time.deltaTime;
       
        if (Input.GetButtonDown("Jump") && isJump == false)
        {
            Jump();
        }

        transform.Translate(h , 0, v);
        //rb.velocity = new Vector3(h * Movespeed * Time.deltaTime, 0, v * Movespeed * Time.deltaTime);
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            isJump = false;
            Debug.Log("false");
        }
        else
        {
            isJump = true;
            Debug.Log("true");
        }
    }
}
