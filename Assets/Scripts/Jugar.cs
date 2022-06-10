using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Jugar : MonoBehaviour
{
    public Canvas jugar;
    public bool playing;

    // Start is called before the first frame update
    void Start()
    {
        playing = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void empezar()
    {
        playing = true;
        jugar.enabled = !enabled;
    }
}
