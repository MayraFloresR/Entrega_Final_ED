//étse código tiene como fin que la tortuga (el jugador) pueda moverse por el mapa

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTortuga : MonoBehaviour
    //Primero se declara una variable de velocidad, que determina que tan rápido va a desplazarse el jugador
{
    public float velocidad;
    
    private Rigidbody Jugador;

    // Start is called before the first frame update
    void Start()
    {
        Jugador = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
        /* Se declara que al presionar determinadas teclas (las flechas), la posición del jugador en el mapa se verá afectada con respecto a sus ejes  */
    {


        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(new Vector3(velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(new Vector3(-velocidad, 0, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(new Vector3(0, velocidad, 0) * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(new Vector3(0, -velocidad, 0) * Time.deltaTime);
        }

    }

    private void OnCollisionEnter(Collision collision)
    {


        //Se declara que si el jugador choca con un ítem de Velocidad, entonces su velocidad se incrementará en 15 puntos
        if (collision.gameObject.tag == "Velocidad")
        {
            velocidad += 15;
        }
    }

}



