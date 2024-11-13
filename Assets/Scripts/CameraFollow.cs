using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player; // Drag player object here in the inspector
    public Vector3 offset = new Vector3(0, 0, -10); // Offset for camera positioning

    void LateUpdate()
    {
        if (player != null)
        {
            Vector3 targetPosition = player.position + offset;
            transform.position = Vector3.Lerp(transform.position, targetPosition, 0.1f);
        }
    }
}
