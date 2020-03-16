using UnityEngine;
using UnityEngine.UI;

public class ProgressBar1 : MonoBehaviour
{
    public int trust = 0;
    public float loadDelay = 2.5f;
    public GameObject levelCompleteUI;
    Slider trustBar;

    // Start is called before the first frame update
    void Start()
    {
        trustBar = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        trustBar.value = trust;
        if (trust == 3)
        {
            levelCompleteUI.SetActive(true);
        }
    }
}
