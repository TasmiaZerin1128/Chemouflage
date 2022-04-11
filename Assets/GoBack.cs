using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GoBack : MonoBehaviour
{

    public string backScene;
    void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("I go back");
            SceneManager.LoadScene(backScene);
        }
    }
    public void buttonBack()
    {
        SceneManager.LoadScene(backScene);
    }
}
