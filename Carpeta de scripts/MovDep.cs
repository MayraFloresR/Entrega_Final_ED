/*
Este código funciona para prohramar el comportamiento de los depredadores en el juego a través de un 
cambio de estados, logrando que, a ccierta distancia y con cierta velocidad, persigan al jugador
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Se ponen los nombres del identificador de acción a utilizar
//Se declara la variable que representará al enemigo y a sus distintos modos de acción
public enum DepIA
{
    Patrulla, Perseguir, Atacar
}

public class MovDep : MonoBehaviour
//Se le asignará al enemigo una velocidad, movimiento y objetivo a perseguir, en este caso, sierra corresponderá al enemigo y target a su presa
{
    public float velocidad;
    public Transform sierra;
    public Transform[] puntos;
    public Transform target;
    public int indiceTarget;
    //esta almacena estado o ubicacion del jugador en el mapa
    public Transform player;
    public DepIA EstadoActual = new DepIA();


    // Start is called before the first frame update
    void Start()
        //Al principio el jugador estará solo patrullando por una ruta delimitada por objetos en blanco
    {

        EstadoActual = DepIA.Patrulla;
        //Se convierte en el elemento inicial el indice 1
        target = puntos[1];
        //.position lee la posición
        sierra.position = target.position;
        velocidad = velocidad * Time.deltaTime;
        indiceTarget = 0;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = target.position - sierra.position;
        //distance va a medir la distancia entre el objeto a mover y el objetivo 
        float distance = Vector3.Distance(sierra.position, target.position);

        float distancePlayer = Vector3.Distance(sierra.position, player.position);

        //Se va a trasladar tomando en cuenta la normalizacion de la velocidad midiendo su espacio en el mundo
        sierra.Translate(dir.normalized * velocidad, Space.World);

        //si la distancia es menor o igual a 0.5 se le suma uno a indice, que es el que indica hacia que punto se va a mover

        if (EstadoActual == DepIA.Patrulla)
        {
            target = puntos[indiceTarget];

            if (distance <= 0.5f)
            {
                //.Length es para que el sistema lea la extensión total del array lee cada nunero o valor dentro del array desde 0 hasta 4
                //El -1 se obliga a que se lea solo hasta el último punto, no se sobrecarga el array
                if (indiceTarget >= puntos.Length - 1)
                {
                    indiceTarget = 0;
                    target = puntos[indiceTarget];
                }

                indiceTarget++;
                target = puntos[indiceTarget];
            }
        }

        //Se programa que, si la distancia entre el jugador y el enemigo es igual o mayor a 15, comenzará la persecución

        if (distancePlayer <= 15)
        {
            EstadoActual = DepIA.Perseguir;
        }
        //Se programa que, si la distancia entre el jugador y el enemigo es igual o menor a 10, el depredadro volverá a patrullar
        else if (distancePlayer > 10)
        {
            EstadoActual = DepIA.Patrulla;
        }

        if (EstadoActual == DepIA.Perseguir)
        {
            target = player;
        }


    }
}