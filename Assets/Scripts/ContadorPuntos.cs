using UnityEngine;
using TMPro; // Asegúrate de importar TMP

public class ContadorPuntos : MonoBehaviour
{
    public TextMeshProUGUI contadorTexto; // Referencia al texto del contador
    public TextMeshProUGUI youWinTexto; // Referencia al texto "You Win"
    private int puntos = 0; // Variable para los puntos

    public GameObject bola; // Referencia al objeto bola

    void Start()
    {
        // Inicializamos el contador en 0 y desactivamos el "You Win"
        contadorTexto.text = "Puntos: 0";
        youWinTexto.gameObject.SetActive(false); // Desactivamos el texto "You Win" al inicio
    }

    // Método para sumar un punto
    public void SumarPunto()
    {
        puntos++; // Incrementa el contador de puntos
        Debug.Log("Punto sumado. Total de puntos: " + puntos); // Depuración para comprobar
        contadorTexto.text = "Puntos: " + puntos; // Actualiza el texto

        // Si llegamos a 12 puntos, mostramos el mensaje "You Win"
        if (puntos >= 12)
        {
            youWinTexto.gameObject.SetActive(true); // Activamos el texto "You Win"
        }
    }

    void Update()
    {
        // Si el texto "You Win" está activo, hacerlo seguir a la bola
        if (youWinTexto.gameObject.activeInHierarchy)
        {
            Vector3 position = bola.transform.position;
            position.y += 1.5f; // Ajuste en Y para colocar el texto encima de la bola
            youWinTexto.transform.position = Camera.main.WorldToScreenPoint(position); // Convertimos la posición de la bola a coordenadas de la pantalla
        }
    }
}
