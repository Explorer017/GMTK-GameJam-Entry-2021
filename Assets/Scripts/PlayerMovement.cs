using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;
    public float jumpspeed;
    private Rigidbody2D rb;
    public bool isGrounded;
    public Transform groundCheck;
    public float checkRadius;
    public LayerMask whatIsGround;
    public LayerMask whatIsDeadly;
    public bool isDead;
    [SerializeField]
    private int extraJumps;
    public int extraJumpsValue;
    public bool jumpHeld;
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        Camera.main.transform.position = new Vector3(this.transform.position.x, 0.5f, -10f);
    }
    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsGround);
        if(isGrounded){
            extraJumps = extraJumpsValue;
        }
        isDead = Physics2D.OverlapCircle(groundCheck.position, checkRadius, whatIsDeadly);
        if((Input.GetAxis("Jump") == 1)  && (extraJumps > 0)){if (jumpHeld == false){rb.velocity = Vector2.up * jumpspeed;extraJumps--;}jumpHeld = true;} else if ((Input.GetAxis("Jump") == 1) && (extraJumps == 0) && isGrounded) {if (jumpHeld == false) {rb.velocity = Vector2.up * jumpspeed;} jumpHeld = true;} else {jumpHeld = false;}
        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * speed, rb.velocity.y);
        animator.SetFloat("SpeedHorizontal", Input.GetAxis("Horizontal") * speed);
        animator.SetFloat("SpeedVertical", rb.velocity.y);
    }
}

