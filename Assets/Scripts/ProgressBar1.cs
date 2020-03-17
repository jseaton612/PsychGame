using UnityEngine;
using UnityEngine.UI;

public class ProgressBar1 : MonoBehaviour
{
    public int trust = 0;
    public int timeRequired = 20;
    public GameObject levelCompleteUI;
    public Text timer;
    public Text successFail;
    Slider trustBar;

    // Start is called before the first frame update
    void Start()
    {
        trustBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        float remainingTime = timeRequired - Time.timeSinceLevelLoad;
        trustBar.value = trust;
        timer.text = (remainingTime < 0 ? 0 : remainingTime).ToString("0");

        if (trust == 3)
        {
            timer.gameObject.SetActive(false);
            levelCompleteUI.SetActive(true);
        }
        else if (remainingTime < 0)
        {
            timer.gameObject.SetActive(false);
            successFail.text = "Failed";
            Failures.failed1 = true;
            levelCompleteUI.SetActive(true);
        }
    }
}
