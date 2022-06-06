using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float movementSpeed, jumpSpeed, onFloor;

    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, 0, movementSpeed);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(0, 0, -movementSpeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(movementSpeed, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-movementSpeed, 0, 0);
        }
        if(Input.GetKey(KeyCode.Space) && onFloor < 2){
            transform.Translate(0, jumpSpeed, 0);
            onFloor += 1;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            onFloor = 0;
        }
    }
}
