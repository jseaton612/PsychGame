using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject hint;
    public Text bText;
    public GameObject finalPanel;

    void Start()
    {
        if (Failures.failed1)
        {
            hint.SetActive(true);
        }
    }

    public void Fail()
    {
        bText.text = "Failed";
        Failures.failed2 = true;
        finalPanel.SetActive(true);
    }

    public void Succeed()
    {
        bText.text = "Success!";
        finalPanel.SetActive(true);
    }
}
