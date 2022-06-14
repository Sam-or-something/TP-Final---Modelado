using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PisoMueve : MonoBehaviour
{
    public float movementSpeed;
    private Jugar boton;
    public GameObject controlador;
    public bool restarting;

    // Start is called before the first frame update
    void Start()
    {
        boton = controlador.GetComponent<Jugar>();
    }

    // Update is called once per frame
    void Update()
    {
        restarting = false;
        if (boton.playing)
        {
            transform.Translate(0, 0, -movementSpeed);
        }
    }

    public void restart()
    {
        gameObject.transform.position =new Vector3(0, 6.5f, 15.68f);
        restarting = true;
    }
}
