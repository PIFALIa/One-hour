using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class kamera : MonoBehaviour
{
    public float sensitivityh = 1f;
    public float sensitivityv = 1f;

    private bool cursorHidden = false;

    private void Update()
    {
        // Проверяем нажатие клавиши (например, клавиши Tab или любую другую по вашему выбору)
        if (Input.GetKeyDown(KeyCode.Tab))
        {
            cursorHidden = !cursorHidden;

            if (cursorHidden)
            {
                Cursor.visible = false;
                Cursor.lockState = CursorLockMode.Locked;
            }
            else
            {
                Cursor.visible = true;
                Cursor.lockState = CursorLockMode.None;
            }
        }
    }

    private void FixedUpdate()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivityh * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityv * Time.deltaTime;
        transform.Rotate(Vector3.up, mouseX);
        transform.Rotate(Vector3.left, mouseY);
    }

}
