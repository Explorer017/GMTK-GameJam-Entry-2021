using UnityEngine;

public class Respawn : MonoBehaviour
{
    //public LayerMask whatIsPlayer;
    public Vector2 respawnLocation;
    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.layer == 3)
        {
            Debug.Log("cheese");
            coll.transform.position = respawnLocation;
        }
    }
}
