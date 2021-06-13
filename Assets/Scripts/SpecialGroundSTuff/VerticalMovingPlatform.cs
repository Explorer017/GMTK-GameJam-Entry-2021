using UnityEngine;

public class VerticalMovingPlatform : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed;
    float origY;
    public float distance;

    // Use this for initialization
    void Start()
    {
        origY = transform.position.y;
        useSpeed = -directionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (origY - transform.position.y > distance)
        {
            useSpeed = directionSpeed;
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed;
        }
        transform.Translate(0, useSpeed * Time.deltaTime, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            other.transform.parent = this.transform;
        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.gameObject.name == "player")
        {
            other.transform.parent = null;
        }
    }
}