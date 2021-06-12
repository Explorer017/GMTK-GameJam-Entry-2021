using UnityEngine;

public class CamFollow : MonoBehaviour
{
    public Transform playerTransform;
    public float upperBound;
    public float lowerBound;
    public float leftBound;
    public float rightBound;
    private void LateUpdate() {transform.position = new Vector3(Mathf.Clamp(playerTransform.position.x, leftBound, rightBound),Mathf.Clamp(playerTransform.position.y, lowerBound, upperBound), transform.position.z);}
}