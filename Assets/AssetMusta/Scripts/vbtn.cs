using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbtn : MonoBehaviour
{
    public GameObject cube;
    public VirtualButtonBehaviour vh;
    // Start is called before the first frame update
    void Start()
    {
        vh.RegisterOnButtonPressed(OnButtonPressed);
        vh.RegisterOnButtonReleased(OnButtonReleased);

        cube.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        cube.SetActive(true);
    }
    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        cube.SetActive(false);
    }
}
