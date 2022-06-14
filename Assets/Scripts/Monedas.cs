using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monedas : MonoBehaviour
{
    public float rotationSpeed;
    public GameObject controlador, piso;
    private PisoMueve script;
    private Jugar boton;
    public MeshRenderer render;

    // Start is called before the first frame update
    void Start()
    {
        script = piso.GetComponent<PisoMueve>();
        boton = controlador.GetComponent<Jugar>();
    }

    // Update is called once per frame
    void Update()
    {
        if (script.restarting)
        {
            render.enabled = true;
        }
        if (boton.playing)
        {
            transform.Rotate(0, 0, rotationSpeed);
        }
    }

    void OnTriggerEnter(Collider col)
    {
        if(col.gameObject.tag == "player")
        {
            render.enabled = false;
        }
    }
}
