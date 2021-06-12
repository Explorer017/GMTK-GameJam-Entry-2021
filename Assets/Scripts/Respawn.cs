using UnityEngine;

public class Respawn : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D coll)
    {
        coll.transform.position = new Vector2(-9.75f, 0.55f);
    }
}
