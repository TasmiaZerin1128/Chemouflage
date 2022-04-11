using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class secondPage : MonoBehaviour
{
    public void periodic()
    {
        SceneManager.LoadScene("PeriodicTable");
    }
    public void build()
    {
        SceneManager.LoadScene("Simulate");
    }
    public void compound()
    {
        SceneManager.LoadScene("Predefined List");
    }
    public void AR()
    {
        SceneManager.LoadScene("AR Book");
    }
    public void quiz()
    {
        SceneManager.LoadScene("Predefined List");
    }

}
