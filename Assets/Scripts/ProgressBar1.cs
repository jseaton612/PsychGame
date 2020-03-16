using UnityEngine;
using UnityEngine.UI;

public class ProgressBar1 : MonoBehaviour
{
    public int trust = 0;
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
    }
}
