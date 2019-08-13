/* Este script tiene como finalidad que los ítems desaparezcan tras ser "agarrados" por el jugador*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestruirItems : MonoBehaviour
{

    //Se indica que cuando el jugador impacte con algún objeto con cierta etiqueta, y al objeto al que corresponde ésta sea destruido

    private void OnCollisionEnter(Collision collision)
    {


        if (collision.gameObject.tag == "Comida")
        {
            Destroy(GameObject.Find("Comidaa"));
        }

        if (collision.gameObject.tag == "Comida01")
        {
            Destroy(GameObject.Find("Comidaa01"));
        }

        if (collision.gameObject.tag == "Velocidad")
        {
            Destroy(GameObject.Find("Velocidadd"));
        }

  
    }

}