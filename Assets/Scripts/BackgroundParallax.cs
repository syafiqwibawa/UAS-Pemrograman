using UnityEngine;

public class BackgroundParallax : MonoBehaviour
{
    public Transform cameraTransform; // Drag camera object here in the inspector
    public float parallaxEffect = 0.5f;

    private Vector3 lastCameraPosition;

    void Start()
    {
        if (cameraTransform != null)
        {
            lastCameraPosition = cameraTransform.position;
        }
    }

    void Update()
    {
        if (cameraTransform != null)
        {
            Vector3 deltaMovement = cameraTransform.position - lastCameraPosition;
            transform.position += new Vector3(deltaMovement.x * parallaxEffect, 0, 0);
            lastCameraPosition = cameraTransform.position;
        }
    }
}
