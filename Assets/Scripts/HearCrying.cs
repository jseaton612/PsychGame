using UnityEngine;

public class HearCrying : MonoBehaviour
{
    bool awake = false;
    bool synced = false;
    Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        if (!awake && Input.GetKey("f"))
        {
            animator.SetTrigger("WakeUp");
            awake = true;
        }

        if (awake && animator.GetCurrentAnimatorStateInfo(0).IsName("WakeUp"))
        {
            synced = true;
        }

        if (synced && animator.GetCurrentAnimatorStateInfo(0).IsName("Asleep"))
        {
            FindObjectOfType<ProgressBar1>().trust++;
            awake = false;
            synced = false;
        }
    }
}
