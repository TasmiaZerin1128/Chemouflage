using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class resetPosition : MonoBehaviour
{
    Vector3 originalPos;
    GameObject objectToFind;
    GameObject videoPlayer;
    GameObject imageTargetToFind;
    GameObject firstTarget;
    GameObject firstObject;
    GameObject secondTarget;


    public MeshRenderer newMesh;
    public float distance;
    // Start is called before the first frame update
    void Start()
    {
        objectToFind = GameObject.FindGameObjectWithTag("NEW");
        firstTarget = GameObject.FindGameObjectWithTag("HTARGET");
        secondTarget = GameObject.FindGameObjectWithTag("OTARGET");
        firstObject = GameObject.FindGameObjectWithTag("OXYGENCOLLIDER");
        Debug.Log("H target  er position " + firstTarget.transform.position);
        Debug.Log("O target  er position " + secondTarget.transform.position);

        // objectToFind.GetComponentInChildren<Renderer>().enabled = false;
        //newMesh = objectToFind.GetComponent<Renderer>();


        objectToFind.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        Debug.Log("H target  er position " + firstTarget.transform.position);
        Debug.Log("O target  er position " + secondTarget.transform.position);


        firstTarget = GameObject.FindGameObjectWithTag("HTARGET");
        secondTarget = GameObject.FindGameObjectWithTag("OTARGET");

        distance = Vector3.Distance(firstTarget.transform.position, secondTarget.transform.position);
       // distance = Vector3.Distance(gameObject.transform.position, firstObject.transform.position);

        Debug.Log("2 ta image target er distance " + distance);

       if (distance > 70)
        {
            Renderer[] rs = GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs)
                r.enabled = true;

            Renderer[] rs2 = firstObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs2)
                r.enabled = true;


            objectToFind.SetActive(false);
        }
       
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("OXYGENCOLLIDER"))
        {
            imageTargetToFind = GameObject.FindGameObjectWithTag("OTARGET");
            originalPos = imageTargetToFind.transform.localPosition;

            //  other.gameObject.GetComponent<Renderer>().enabled = false;
            //  gameObject.GetComponent<Renderer>().enabled = false;

            Renderer[] rs = GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs)
                r.enabled = false;

            Renderer[] rs2 = firstObject.GetComponentsInChildren<Renderer>();
            foreach (Renderer r in rs2)
                r.enabled = false;

            //    other.gameObject.SetActive(false);

            //   gameObject.SetActive(false);


            //next work
            objectToFind.SetActive(true);


            //  originalPos = transform.localPosition;

            objectToFind.transform.localPosition = originalPos;
            Debug.Log("Baccha hbe na" + objectToFind.transform.localPosition.x + objectToFind.transform.localPosition.y + objectToFind.transform.localPosition.z);
            //    StartCoroutine(ShowAndHide(objectToFind, 3.0f));


        }


    }


  

}