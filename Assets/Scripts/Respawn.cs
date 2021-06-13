using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Respawn : MonoBehaviour
{
    //public LayerMask whatIsPlayer;
    public Vector2 respawnLocation;
    private AudioSource audio;
    private void Start()
    {
        audio = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.name == "player")
        {
            if (coll.gameObject.transform.childCount > 2) {
                audio.Play();
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            } else {
                coll.transform.position = respawnLocation;
                audio.Play();
            }
        }
    }
}
