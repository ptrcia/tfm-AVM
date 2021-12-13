using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour
{
    //private GameObject esfera;
    Collider colisionador;

    void Start()
    {
        colisionador = GetComponent<Collider>();
    }

    void Update()
    {
        if (colisionador.isTrigger == true)
        {
            colisionador.enabled = !colisionador.enabled;

            Debug.Log("Collider.enabled = " + colisionador.enabled);
        }
    }

    /*void OnTriggerEnter(Collider other)
    {
        Debug.Log("Player has entered trigger");
        gameObject.GetComponent(Collider).isTrigger = true;
    }

    void OnTriggerStay(Collider other)
    {
        Debug.Log("Player is in trigger");
        gameObject.GetComponent(Collider).isTrigger = true;
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log("Player left trigger");
        gameObject.GetComponent(Collider).isTrigger = false;
        esfera = Collider.enabled(false);
    }*/

}