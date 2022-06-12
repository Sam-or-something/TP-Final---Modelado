using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueMueve : MonoBehaviour
{
    private Jugar boton;
    public GameObject controlador;
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        boton = controlador.GetComponent<Jugar>();
    }

    // Update is called once per frame
    void Update()
    {
        if(boton.playing){
            transform.position += new Vector3(movementSpeed, 0, 0);
            if(transform.position.x >= 4 || transform.position.x <= -4){
                movementSpeed = -movementSpeed;
            }
        }
    }
}
