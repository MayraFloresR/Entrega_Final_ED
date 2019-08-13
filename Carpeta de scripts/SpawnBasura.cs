/*  éste código funciona para hacer que se generen objetos que caigan hacia el suelo del mapa cada cierto tiempo */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBasura : MonoBehaviour
{
    //Primero se declara que habrá un objeto de juego que será la basura a generar
    // Se dará un tiempo, que será el intervalo que pasará entre cada objeto a generar
    public GameObject BasuraPrefab;
    public float TiempoGener = 1.75f;
    // Start is called before the first frame update
    void Start()
        //Se mandan a generar los objetos inicciando en cero, para que en cuanto el juego empiece, éstos se generen
    {
        InvokeRepeating("CrearEnem", 0f, TiempoGener);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Se creará un proceso de generación de enemigos basados en un objeto generador de los mismos
    void CrearEnem()
    {
        Instantiate(BasuraPrefab, transform.position, Quaternion.identity);
    }


}
