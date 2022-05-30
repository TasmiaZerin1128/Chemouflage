using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedelay : MonoBehaviour
{
    public GameObject obj;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        StartCoroutine(ShowAndHide(obj, 5.0f)); // 1 second
    }
    IEnumerator ShowAndHide(GameObject go, float delay)
    {
        go.SetActive(true);
        yield return new WaitForSeconds(delay);
        go.SetActive(false);
    }
}
