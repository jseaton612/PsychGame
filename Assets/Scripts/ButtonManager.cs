using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    public Button info, start, hideInfo;
    public Text infoText;

    // Start is called before the first frame update
    void Start()
    {
        start.onClick.AddListener(Load);
        info.onClick.AddListener(ShowInfo);
        hideInfo.onClick.AddListener(HideInfo);
    }

    void Load()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    void ShowInfo()
    {
        info.gameObject.SetActive(false);
        start.gameObject.SetActive(false);
        hideInfo.gameObject.SetActive(true);
        infoText.gameObject.SetActive(true);
    }
    void HideInfo()
    {
        info.gameObject.SetActive(true);
        start.gameObject.SetActive(true);
        hideInfo.gameObject.SetActive(false);
        infoText.gameObject.SetActive(false);
    }
}
