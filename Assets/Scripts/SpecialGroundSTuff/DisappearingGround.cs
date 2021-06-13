using UnityEngine;

public class DisappearingGround : MonoBehaviour
{
    public GameObject player;
    private Renderer renderer;
    public Collider2D box;
    public int playersRequired;
    public bool unlocked = false;
    private void Start()
    {
        renderer = GetComponent<Renderer>();
        //box = GetComponent<TilemapCollider2D>();
    }
    private void Update()
    {
        if (player.transform.childCount > playersRequired && !unlocked)
        {
            renderer.enabled = false;
            box.enabled = false;
            unlocked = true;
        }
    }
}
