using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lluvia : MonoBehaviour
{
    public GameObject bomb;
    GameObject clone;
    float timer;
    public float timeBetweenBombs;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;
        if (timer <= 0 && transform.position.z >= -6)
        {
            clone = Instantiate(bomb);
            clone.transform.position = gameObject.transform.position - Vector3.forward;
            timer = timeBetweenBombs;
        }
    }
}
