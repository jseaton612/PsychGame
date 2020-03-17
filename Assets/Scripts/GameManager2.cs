using UnityEngine;
using UnityEngine.UI;

public class GameManager2 : MonoBehaviour
{
    public int timeRequired = 30;
    public Text timer;
    public GameObject balance;
    public Text bText;
    public GameObject finalPanel;

    public void Update()
    {
        float remainingTime = timeRequired - Time.timeSinceLevelLoad;
        timer.text = (remainingTime < 0 ? 0 : remainingTime).ToString("0");

        if (remainingTime < 0 && balance.transform.position.y > -5)
        {
            bText.text = "You won!\nWell Played";
            finalPanel.SetActive(true);
        }

        else if (balance.transform.position.y < -5)
        {
            bText.text = "GAME OVER\nThanks for playing!";
            finalPanel.SetActive(true);
        }
    }
}
