using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControladorJugador : MonoBehaviour
{
    public float movementSpeed, jumpForce;
    private Jugar boton;
    public GameObject controlador;
    bool onFloor;
    Rigidbody rb;

    void Start()
    {
        onFloor = true;
        rb = GetComponent<Rigidbody>();
        boton = controlador.GetComponent<Jugar>();
    }

    void Update()
    {
        if (boton.playing)
        {
            if (Input.GetKey(KeyCode.D) && transform.position.x > -4)
            {
                transform.Translate(movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x < 4)
            {
                transform.Translate(-movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.W) && onFloor)
            {
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
                onFloor = false;
            }
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
        if(col.gameObject.tag == "Win")
        {
            boton.playing = false;
        }
    }
}
