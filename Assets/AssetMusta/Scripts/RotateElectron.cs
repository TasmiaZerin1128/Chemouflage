using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateElectron : MonoBehaviour
{
    public float speed;

    Vector3 Oldposition;
    private void Start()
    {
        Oldposition = transform.position;
    }

    void Update()
    {
        //transform.RotateAround(Oldposition,new Vector3(0f,0f,1f), speed*Time.deltaTime);
        transform.Rotate(new Vector3(0,0,speed*Time.deltaTime));  
    }
}
