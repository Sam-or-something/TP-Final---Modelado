using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ControladorJugador : MonoBehaviour
{
    public float movementSpeed, jumpForce;
    private Jugar boton;
    public GameObject controlador;
    public Canvas ganaste, perdiste;
    bool onFloor;
    public bool winning;
    Rigidbody rb;
    public AudioSource source;
    public AudioClip roblox;

    void Start()
    {
        ganaste.enabled = !enabled;
        perdiste.enabled = !enabled;
        onFloor = true;
        rb = GetComponent<Rigidbody>();
        boton = controlador.GetComponent<Jugar>();
    }

    void Update()
    {
        if (boton.playing)
        {
            if (Input.GetKey(KeyCode.D) && transform.position.x <= 4)
            {
                transform.Translate(movementSpeed, 0, 0);
            }
            if (Input.GetKey(KeyCode.A) && transform.position.x >= -4)
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
            source.clip = roblox;
            source.Play();
            perdiste.enabled = enabled;
            boton.playing = false;
            Destroy(gameObject);
        }
        if(col.gameObject.tag == "Win")
        {
            winning = true;
            boton.playing = false;
            ganaste.enabled = enabled;
        }
    }
}
