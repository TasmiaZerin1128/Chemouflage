using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("2nd Page");
    }
    public void quitGame()
    {
        Debug.Log("I Quit");
        Application.Quit();
    }
    public void Update()
    {
        if(Input.GetKey(KeyCode.Escape))
        {
            Debug.Log("I Quit");
            Application.Quit();
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex-1);
        }
    }

}
