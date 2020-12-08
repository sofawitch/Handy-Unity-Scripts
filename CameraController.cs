using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera maincamera;
    public float zoomOutMin = 1;
    public float zoomOutMax = 8;
    public float increment;

    void Update()
    {
        var zoom = -1;
        maincamera.orthographicSize += Input.mouseScrollDelta.y * zoom;
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize - increment, zoomOutMin, zoomOutMax);
    }
}
