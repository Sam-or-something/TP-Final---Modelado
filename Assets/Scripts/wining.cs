using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wining : MonoBehaviour
{
    private ControladorJugador script;
    public int cantInt;
    public GameObject jugador, woooo;
    GameObject clone;

    // Start is called before the first frame update
    void Start()
    {
        script = jugador.GetComponent<ControladorJugador>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.winning)
        {
            script.winning = false;
            for(int i = cantInt; i >= 0; i--)
            {
                clone = Instantiate(woooo);
            }
        }
    }
}
