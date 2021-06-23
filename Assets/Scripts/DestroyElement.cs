using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyElement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player") //Compruebo que sea la pelota
        {
            other.GetComponent<Controlador>().ContadorCubosDest();
            Destroy(gameObject);
        }
    }
}
