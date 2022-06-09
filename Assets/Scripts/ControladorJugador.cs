using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float movementSpeed, jumpForce;
    bool onFloor;
    Rigidbody rb;

    void Start()
    {
        onFloor = true;
        rb = GetComponent<Rigidbody>();
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
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            onFloor = false;
        }
    }
    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            onFloor = true;
        }
        if (col.gameObject.tag == "Die")
        {
            Destroy(gameObject);
        }
    }
}
