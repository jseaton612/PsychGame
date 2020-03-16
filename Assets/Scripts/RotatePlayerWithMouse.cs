using UnityEngine;

public class RotatePlayerWithMouse : MonoBehaviour
{
    public float sensitivity = 1f;
    void Update()
    {
        float HRot = Input.GetAxis("Mouse X");
        transform.Rotate(0, HRot, 0);
    }
}
