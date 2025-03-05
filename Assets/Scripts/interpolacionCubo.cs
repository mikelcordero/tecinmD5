using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interpolacionCubo : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación

    void Update()
    {
        // Hacer que el cubo gire sobre sí mismo en el eje Y
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bola")) // Si la bola pasa por encima del cubo
        {
            Destroy(gameObject); // Eliminar el cubo inmediatamente
        }
    }
}