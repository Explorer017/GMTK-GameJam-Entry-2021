using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manu : MonoBehaviour
{
    public void playGame()
    {
        SceneManager.LoadScene("LevelSelect");
    }

    public void quitGame()
    {
        Application.Quit();
    }
}
