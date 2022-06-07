using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float movementSpeed, jumpForce;
    bool onFloor;

    void Start()
    {
        onFloor = true;
    }

    void Update()
    { 
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.W) && onFloor){
            transform.Translate(0, jumpForce, 0);
            onFloor = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            onFloor = true;
        }
    }
}
