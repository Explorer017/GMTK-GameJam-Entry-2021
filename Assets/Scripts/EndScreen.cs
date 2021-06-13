using UnityEngine;
using UnityEngine.SceneManagement;

public class EndScreen : MonoBehaviour
{
    public void playAgain()
    {
        Debug.Log("PLEASE HELP ME1");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    public void nextLevel()
    {
        Debug.Log("PLEASE HELP ME2");
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void toMenu()
    {
        Debug.Log("PLEASE HELP ME3");
        SceneManager.LoadScene(0);
    }
}
