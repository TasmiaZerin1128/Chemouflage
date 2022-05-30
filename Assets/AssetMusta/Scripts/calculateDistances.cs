using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class calculateDistances : MonoBehaviour
{
    public GameObject oxygen;
    public GameObject carbon;
    public float distance;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(oxygen.transform.position,carbon.transform.position);

    }
}
