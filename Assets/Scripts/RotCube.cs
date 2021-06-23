using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotCube : MonoBehaviour
{
    public float vAngular = 45.0f;   //variable para lograr la rotación

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0.0f, vAngular * Time.deltaTime, 0.0f);
    }
}
