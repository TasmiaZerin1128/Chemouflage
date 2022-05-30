using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scaleAndRotateSlider : MonoBehaviour
{
    private Slider scaleSlider;
    private Slider rotateSlider;

    public float scaleMinValue;
    public float scaleMaxValue;
    void Start()
    {
        scaleSlider = GameObject.Find("scaleSliders").GetComponent<Slider>();
        scaleSlider.minValue = scaleMinValue;
        scaleSlider.maxValue = scaleMaxValue;

        scaleSlider.onValueChanged.AddListener(ScaleSliderUpdate);
    
    }

   void ScaleSliderUpdate(float value)
    {
        transform.localScale = new Vector3(value, value, value);
    }

    
}
