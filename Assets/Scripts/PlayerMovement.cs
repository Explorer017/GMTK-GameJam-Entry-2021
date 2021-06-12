using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    private Rigidbody2D rb;
    public Vector2 movement;
    public bool isGrounded;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Camera.main.transform.position = new Vector3(this.transform.position.x, 0.5f, -10f);
    }
    void FixedUpdate()
    {
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Entered");
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit2D(Collision2D collision)
    {
        Debug.Log("Exited");
        if (collision.gameObject.CompareTag("ground"))
        {
            isGrounded = false;
        }
    }
}
