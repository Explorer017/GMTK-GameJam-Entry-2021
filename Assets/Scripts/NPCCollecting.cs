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
        transform.SetParent(playerTransform);
        animator.SetBool("attached", true);
        transform.position = new Vector2(playerTransform.position.x,playerTransform.position.y+(0.7f*(playerTransform.childCount-2)));
    }
}
