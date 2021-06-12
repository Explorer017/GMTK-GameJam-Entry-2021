using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    private float useSpeed;
    public float directionSpeed = 5.0f;
    float origY;
    public float distance = 10.0f;

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
            useSpeed = directionSpeed; //flip direction
        }
        else if (origY - transform.position.y < -distance)
        {
            useSpeed = -directionSpeed; //flip direction
        }
        transform.Translate(0, useSpeed * Time.deltaTime, 0);
    }
}