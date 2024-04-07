using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public float sensitivity = 2f; // Adjust this value to control the sensitivity of the mouse movement
    public bool invertYAxis = false; // Set this to true if you want to invert the Y-axis movement

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity * (invertYAxis ? -1 : 1);

        // Translate the camera based on mouse input
        transform.Translate(Vector3.right * mouseX);
        transform.Translate(Vector3.up * mouseY);
    }
}
