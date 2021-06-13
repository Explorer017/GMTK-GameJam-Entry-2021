using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour
{
    public bool gameIsPaused = false;
    public GameObject pausemenu;
    private void Start()
    {
        pausemenu.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)){
            if (gameIsPaused)
            {
                resume();
            } else {
                stop();
            }
        }
    }
    public void resume()
    {
        pausemenu.SetActive(false);
        Time.timeScale = 1f;
        gameIsPaused = false;
    }

    public void stop()
    {
        pausemenu.SetActive(true);
        Time.timeScale = 0f;
        gameIsPaused = true;
    }
}
