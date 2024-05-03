using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotateText : MonoBehaviour
{
    public float rotationSpeed = 30f; // Adjust the speed of rotation as needed

    void Update()
    {
        // Rotate the object around its own axis
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);
    }
}
