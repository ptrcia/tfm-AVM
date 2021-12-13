using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    //[SerializeField] private Transform gameObject;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //si el que se cae tiene la etiqueta player
        {
            Destroy(gameObject);
        }
        //Debug.Log(other);
    }
}
