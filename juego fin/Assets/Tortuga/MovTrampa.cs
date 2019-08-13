/*  Este código es para poder programar el movimiento que tendrán las trampas    */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovTrampa : MonoBehaviour
{
    //Lo primero a hacer es declarar que habrá un movimiento del objeto, se le van a asignar una velocidad y una distancia
    private Vector3 originalTransform;
    public float velocidad;
    public float distancia;

    // Start is called before the first frame update
    //Se declara que el objeto está en una posición específica
    void Start()
    {
        originalTransform = this.transform.position;
    }

    // Update is called once per frame
    //Aquí, elcódigo hace que el objeto se mueva haciendo uso de los valores de la distancia y la velocidad en conjunto
    void Update()
    {
        transform.position = originalTransform + new Vector3(Mathf.Sin(Time.time * velocidad) * distancia, 0);

    }
}