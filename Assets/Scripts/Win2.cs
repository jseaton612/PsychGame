using UnityEngine;

public class Win2 : MonoBehaviour
{
    public GameManager levelCompleteUI;

    void Update()
    {
        if (transform.position.y < -36)
        {
            levelCompleteUI.Succeed();
        }
    }
}
