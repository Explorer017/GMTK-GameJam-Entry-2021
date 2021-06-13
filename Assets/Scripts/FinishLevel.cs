using UnityEngine.SceneManagement;
using UnityEngine;

public class FinishLevel : MonoBehaviour
{
    public GameObject endscreen;
    public GameObject playermovement;
    private void Start()
    {
        endscreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        endscreen.SetActive(true);
        playermovement.GetComponent<PlayerMovement>().enabled = false;
    }
}
