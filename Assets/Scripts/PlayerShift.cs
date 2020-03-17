using UnityEngine;

public class PlayerShift : MonoBehaviour
{
    public float factor = .1f;
    public float step = .08f;
    public Rigidbody2D pivot;

    private void Start()
    {
        pivot = GetComponent<Rigidbody2D>();
    }
    void FixedUpdate()
    {
        if (Failures.failed2)
        {
            pivot.AddForce(new Vector2(Input.GetAxis("Horizontal") * factor, 0));
        }
        else
        {
            transform.Translate(Input.GetAxis("Horizontal") * step, 0, 0);
        }
    }
}
