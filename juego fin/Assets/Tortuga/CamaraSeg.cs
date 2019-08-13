/*   Este script sirve opara que la cámara pueda perseguir al jugador (lo enfoque todo el tiempo)   */ 

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamaraSeg : MonoBehaviour
{
    //En primer lugar se declaran el objetivo y velocidad de la cámara
    public Transform target;
    public float smoothSpeed = 0.125f;
    public Vector3 offset;

    // Update is called once per frame
    void LateUpdate()
    {
   //En este punto se declara que la posicion de la cámara se ajustará tomando en cuenta a su objetivo

        Vector3 desiredPosition = target.position + offset;
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, desiredPosition, smoothSpeed);
        transform.position = smoothedPosition;

        //transform.LookAt(target);
    }
}