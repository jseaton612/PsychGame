using UnityEngine;

public class TriggerEnd : MonoBehaviour
{
    public GameManager levelCompleteUI;

    private void OnTriggerEnter(Collider other)
    {
        levelCompleteUI.Fail();
    }
}
