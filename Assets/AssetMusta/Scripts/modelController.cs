using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class modelController : MonoBehaviour
{
    private Rigidbody rb;
    Quaternion Oldposition;
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Oldposition = transform.rotation;
    }

    // Update is called once per frame
    void Update()
    {
        float x = CrossPlatformInputManager.GetAxis("Horizontal");
        float y = CrossPlatformInputManager.GetAxis("Vertical");
        

        Vector3 movement = new Vector3(x, 0.5f, y);

        rb.velocity = movement * 3f;
         if(x!=0 && y!=0)
        {

          
           transform.eulerAngles = new Vector3(transform.eulerAngles.x, Mathf.Atan2(x, y) * Mathf.Rad2Deg, transform.eulerAngles.z);
        }
        else
        {
            Debug.Log("Released");
            transform.rotation = Oldposition;
        }


    }
}
