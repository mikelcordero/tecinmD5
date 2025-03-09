using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeguirBola : MonoBehaviour
{
    public Transform bola; // Referencia a la bola
    public Vector3 offset = new Vector3(0, 3, -5); // Distancia de la cámara

    void LateUpdate()
    {
        if (bola != null)
        {
            transform.position = bola.position + offset;
            transform.LookAt(bola); // La cámara siempre mira a la bola
        }
    }
}
