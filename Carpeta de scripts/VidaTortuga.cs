/*  Este código tiene como función hacer que la tortuga tenga puntos de vida y por ende, pueda morir, sufrir daño o regenerarse */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class VidaTortuga : MonoBehaviour

{
    //Se declara una variable flotatne para el valor de la vida y se declra que habrá una interfaz de texto
    public float vida;
    public Text vidaText;

    private void Start()
    {
        //Se vincula la interfaz de texto con el valor de la vida del jugador
        vidaText.text = vida.ToString();
    }

    private void Update()
    {
        //Se declara que, junto con los cambios en la vida, se actualizará también la interfaz de texto
        vidaText.text = vida.ToString();
        //Se condiciona que, si la vida llega a cero, el jugador sea destruido  
        if (vida <= 0)
        {
            Destroy(GameObject.Find("Tortuga"));
        }
    }
    //En esta parte se toman en cuenta las colisiones con ítems, trampas y depredadores

    private void OnCollisionEnter(Collision collision)
    {


        //Se declara que si el jugador choca contra alguna trampa o depredador, sus puntos de vida bajaraán en 100 puntos

        if (collision.gameObject.tag == "Depredador")
        {
            vida -= 100;
        }

        if (collision.gameObject.tag == "Trampa")
        {
            vida -= 100;
        }

        //Se declara que si el jugador choca con un ítem de comida, entonces su vida se incrementará en 15 puntos
        if (collision.gameObject.tag == "Comida")
        {
            vida += 15;
        }

        if (collision.gameObject.tag == "Comida01")
        {
            vida += 15;
        }
    }

//En esta parte se declara que si el jugador entra en contacto con un objeto trigger de tipo basura, perderá 25 puntos de vida

    private void OnTriggerEnter(Collider other)
    {
      
        
            if (other.gameObject.tag == "Basura")
            {
                vida -= 25;
            }
        

    }



}

