using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bomb : MonoBehaviour
{
    public float movementSpeed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(0, 0, -movementSpeed);
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Piso")
        {
            Destroy(gameObject);
        }
    }
}
