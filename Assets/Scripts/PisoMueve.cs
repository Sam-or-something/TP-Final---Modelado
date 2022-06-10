using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoMueve : MonoBehaviour
{
    public float movementSpeed;
    private Jugar boton;
    public GameObject controlador;

    // Start is called before the first frame update
    void Start()
    {
        boton = controlador.GetComponent<Jugar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (boton.playing)
        {
            transform.Translate(0, 0, -movementSpeed);
        }
    }
}
