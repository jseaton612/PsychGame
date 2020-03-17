using UnityEngine;

public class PlayerShift : MonoBehaviour
{
    public float step = .1f;
    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(Input.GetAxis("Horizontal") * step, 0, 0);
    }
}
