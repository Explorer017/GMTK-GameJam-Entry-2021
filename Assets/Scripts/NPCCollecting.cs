using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class NPCCollecting : MonoBehaviour
{
    public bool comprimised;
    public Light2D light;
    private Transform transform;
    public Transform playerTransform;
    public Vector3 player;
    public Animator animator;

    private void Start()
    {
        transform = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        light.pointLightOuterRadius += 1;
        Object.Destroy(GetComponent<BoxCollider2D>());
        Debug.Log("Steve has been comprimised");
        comprimised = true;
        player = GameObject.Find("player").transform.position;
        transform.SetParent(playerTransform);
        transform.position = new Vector2(player.x,(player.y+1)-0.1f);
        Debug.Log("STEVEN IS BECOMING ATTACHED");
        animator.SetBool("attached", true);
        Debug.Log("STEVE HAS BEEN STEVED");
        //transform.position = new Vector2(0, (float)0.8);
        //transform.position = new Vector3(0, (float)0.8, 0);
    }
}
