using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flee : MonoBehaviour
{
    // Start is called before the first frame update
    private float old_pos;
    private float player_old_pos;
    private Transform player;
    private float bed;



    void Start()
    {
        //posicion del objeto inicial
        old_pos = this.transform.position.x;
        //Posicion del jugador inicial
        player_old_pos = GameObject.FindWithTag("Player").transform.position.x;
        bed = GameObject.FindWithTag("Bed").transform.position.x;
        transform.position = new Vector3(0, 0, 0);


    }
    void Update()
    {
        if (GameObject.FindWithTag("Player").transform.position.x > player_old_pos)
        {
            //esto se activa cuando la posicion actual del jugador es mayor en el eje de coordenadas x
            print("moviendo positivo en las x");
            bed.position.x++;
            //asignar nueva posicion en las xde tu objeto en funcion de que el jugador incrementa su posicion en las x
            //1transform.position.x = transform.position.x;

        }
        if (player_old_pos > GameObject.FindWithTag("Player").transform.position.x)
        {
            print("moviendo negativo en las x");

            //asignar nueva posicion en las de tu objeto en funcion de que el jugador decrementa su posicion en las x

        }
        player_old_pos = GameObject.FindWithTag("Player").transform.position.x;
    }
}
 