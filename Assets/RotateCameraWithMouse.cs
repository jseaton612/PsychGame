using UnityEngine;

public class RotateCameraWithMouse : MonoBehaviour
{
    public float sensitivity = 1f;
    void Update()
    {
        float VRot = Input.GetAxis("Mouse Y");
        transform.Rotate(-VRot, 0, 0);
    }
}
