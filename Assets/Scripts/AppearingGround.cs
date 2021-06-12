using UnityEngine;

public class AppearingGround : MonoBehaviour
{
    public GameObject player;
    private Renderer renderer;
    private BoxCollider2D box;
    public int playersRequired;
    public bool unlocked = false;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.enabled = false;
        box = GetComponent<BoxCollider2D>();
        box.enabled = false;
    }
    private void Update()
    {
        if (player.transform.childCount > playersRequired && !unlocked)
        {
            renderer.enabled = true;
            box.enabled = true;
        }
    }
}
