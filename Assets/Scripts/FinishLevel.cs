using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //Maybe Create Well done screen
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
