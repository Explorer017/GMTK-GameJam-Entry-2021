using UnityEngine;
using UnityEngine.Audio;

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
            audio.Play();
            coll.transform.position = respawnLocation;
        }
    }
}
