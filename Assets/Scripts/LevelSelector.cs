using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelSelector : MonoBehaviour
{
    public void LoadScene(string scene)
    {
        Debug.Log("WHY IS NOTHING WORKING");
        SceneManager.LoadScene(scene);
    }

}