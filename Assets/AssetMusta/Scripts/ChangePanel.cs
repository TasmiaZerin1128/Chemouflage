using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangePanel : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        Image img = GameObject.Find("Oxygen").GetComponent<Image>();
        img.color = Color.green;
    }
}
