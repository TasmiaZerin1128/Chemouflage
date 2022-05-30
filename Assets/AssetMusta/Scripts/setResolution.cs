using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setResolution : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Switch to 2160 x 1080 full-screen
        Screen.SetResolution(2160, 1080, true);
    }
}
