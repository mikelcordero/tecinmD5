using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class interpolacionCubo : MonoBehaviour
{
    public float velocidadRotacion = 100f; // Velocidad de rotación

    // Referencia al script ContadorPuntos (asegúrate de asignarlo desde Unity)
    private ContadorPuntos contadorPuntos;

    void Start()
    {
        // Obtenemos la referencia al script ContadorPuntos
        contadorPuntos = FindObjectOfType<ContadorPuntos>();
    }

    void Update()
    {
        // Hacer que el cubo gire sobre sí mismo en el eje Y
        transform.Rotate(Vector3.up * velocidadRotacion * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        // Si la bola pasa por encima del cubo
        if (other.CompareTag("Bola"))
        {
            // Sumar un punto al contador de puntos
            if (contadorPuntos != null)
            {
                contadorPuntos.SumarPunto(); // Suma un punto
            }

            // Eliminar el cubo inmediatamente después de pasar la bola
            Destroy(gameObject);
        }
    }
}
