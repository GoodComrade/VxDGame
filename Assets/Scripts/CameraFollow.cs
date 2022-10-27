using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;


    void LateUpdate()
    {
        Vector3 desirePosition = target.position + offset;
        Vector3 smoothPosition = Vector3.LerpUnclamped(transform.position, desirePosition, smoothSpeed * Time.deltaTime);
        transform.position = smoothPosition;
    }
}
