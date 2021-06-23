using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoEsfera : MonoBehaviour
{
    public int Force = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GetComponent<Controlador>().EstadoJuego() == true)
        {
            if (Input.GetKey(KeyCode.RightArrow))
            {
                GetComponent<Rigidbody>().AddForce(Force, 0.0f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.LeftArrow))
            {
                GetComponent<Rigidbody>().AddForce(-Force, 0.0f, 0.0f);
            }
            else if (Input.GetKey(KeyCode.UpArrow))
            {
                GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, Force);
            }
            else if (Input.GetKey(KeyCode.DownArrow))
            {
                GetComponent<Rigidbody>().AddForce(0.0f, 0.0f, -Force);
            }
        }
        else
        {
            GetComponent<Rigidbody>().isKinematic = true;
        }
    }
}
