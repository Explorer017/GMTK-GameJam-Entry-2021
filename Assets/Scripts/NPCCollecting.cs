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
    public BoxCollider2D box;
    private AudioSource audio;

    private void Start()
    {
        audio = GetComponent<AudioSource>();
        transform = GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        light.pointLightOuterRadius += 1;
        Object.Destroy(GetComponent<BoxCollider2D>());
        Debug.Log("Steve has been comprimised");
        comprimised = true;
        audio.Play();
        transform.SetParent(playerTransform);
        animator.SetBool("attached", true);
        transform.position = new Vector2(playerTransform.position.x,playerTransform.position.y+(0.7f*(playerTransform.childCount-2)));
        box.size = new Vector2(box.size.x, box.size.y + 0.7f);
        box.offset = new Vector2(box.offset.x, box.offset.y + 0.35f);

    }
}
