using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform playerTransform;
    public Transform boundsTransform;
    private void LateUpdate() {
        transform.position = new Vector3(
            Mathf.Clamp(playerTransform.position.x, boundsTransform.position.x - (boundsTransform.localScale.x / 2 ), boundsTransform.position.x + (boundsTransform.localScale.x / 2)), 
            Mathf.Clamp(playerTransform.position.y, boundsTransform.position.y - boundsTransform.localScale.y - (boundsTransform.localScale.y / 2), boundsTransform.position.y + (boundsTransform.localScale.y / 2)), 
            transform.position.z
        );
    }
}