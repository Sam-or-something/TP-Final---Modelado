using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugar : MonoBehaviour
{
    public Canvas jugar;
    public bool playing;
    public AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (!playing)
        {
            source.enabled = !enabled;
        }
        else
        {
            source.enabled = enabled;
        }
    }

    public void empezar()
    {
        playing = true;
        jugar.enabled = !enabled;
    }
}
