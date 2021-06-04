using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] private Transform player;
    [SerializeField] private Transform respawnPoint;

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) //si el que se cae tiene la etiqueta player
        { 
            player.transform.position = respawnPoint.transform.position;
        }
        //Debug.Log(other);
    }
}