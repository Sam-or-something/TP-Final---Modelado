using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lluvia : MonoBehaviour
{
    public GameObject bomb;
    GameObject clone;
    public float elapsedTime;

    // Start is called before the first frame update
    void Start()
    {
        elapsedTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        elapsedTime += Time.deltaTime;
        if(Mathf.Floor(elapsedTime) == 3)
        {
            clone = Instantiate(bomb);
            clone.transform.position = gameObject.transform.position - Vector3.forward;
            elapsedTime = 0;
        }
    }
}
