using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float verticalForceFactor = 1.3f;
    Rigidbody ball;

    void Start()
    {
        ball = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        ball.AddForce(Input.GetAxis("Horizontal") * (Failures.failed1 ? 0 : 1), 0, Input.GetAxis("Vertical") * verticalForceFactor);
    }
}
