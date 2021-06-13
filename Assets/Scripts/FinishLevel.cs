using UnityEngine;
using UnityEngine.Audio;

public class FinishLevel : MonoBehaviour
{
    private AudioSource audio;
    public GameObject endscreen;
    public GameObject playermovement;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
        endscreen.SetActive(false);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        audio.Play();
        endscreen.SetActive(true);
        playermovement.GetComponent<PlayerMovement>().enabled = false;
    }
}
