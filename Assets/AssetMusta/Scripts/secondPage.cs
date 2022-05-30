using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondPage : MonoBehaviour
{
    public void learn()
    {
        SceneManager.LoadScene("PeriodicTable");
    }
    public void play()
    {
        SceneManager.LoadScene("Game");
    }
}
