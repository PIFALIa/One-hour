using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRotateDIO : MonoBehaviour
{
    public float sensitivityh = 1f;
    public float sensitivityv = 1f;

    void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivityh * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityv * Time.deltaTime;
        transform.Rotate(Vector3.up, mouseX);
        transform.Rotate(Vector3.left, mouseY);
    }
}
