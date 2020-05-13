using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartExit : MonoBehaviour
{
    public void StartC()
    {
        SceneManager.LoadScene("Russia");
    }
    public void Exit()
    {
        Application.Quit();
    }
}
