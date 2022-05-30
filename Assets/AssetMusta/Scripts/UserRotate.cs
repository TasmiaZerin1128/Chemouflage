using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UserRotate : MonoBehaviour
{

    float rotationSpeed = 3f;
    Quaternion Oldposition;

    private void Start()
    {
        Oldposition = transform.rotation;
    }
    public void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click.");
            float XaxisRotation = Input.GetAxis("Mouse X") * rotationSpeed;
            float YAxisRotation = Input.GetAxis("Mouse Y") * rotationSpeed;
            transform.Rotate(XaxisRotation, YAxisRotation, 0);
               // transform.Rotate(Vector3.down, XaxisRotation);
                // transform.Rotate(Vector3.right, YAxisRotation);
        }
        else
        {
            Debug.Log("Released");
            transform.rotation = Oldposition;
        } 
    }

}
