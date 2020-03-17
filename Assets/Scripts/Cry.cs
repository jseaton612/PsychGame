using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cry : MonoBehaviour
{
    AudioSource baby;

    private void Start()
    {
        baby = GetComponent<AudioSource>();
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("f"))
        {
            baby.Play();
            Debug.Log("play");
        }

        if (Input.GetKeyUp("f"))
        {
            baby.Stop();
            Debug.Log("Stop");
        }
    }
}
