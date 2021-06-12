using UnityEngine;

public class HorizontalMovingPlatform : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed;
    float origX;
    public float distance;

    // Use this for initialization
    void Start()
    {
        origX = transform.position.x;
        useSpeed = -directionSpeed;
    }

    // Update is called once per frame
    void Update()
    {
        if (origX - transform.position.x > distance)
        {
            useSpeed = directionSpeed;
        }
        else if (origX - transform.position.x < -distance)
        {
            useSpeed = -directionSpeed;
        }
        transform.Translate(useSpeed * Time.deltaTime, 0, 0);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        other.transform.parent = this.transform;
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        other.transform.parent = null;
    }
}