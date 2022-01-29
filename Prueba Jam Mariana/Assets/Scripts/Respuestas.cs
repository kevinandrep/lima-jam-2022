using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respuestas : MonoBehaviour
{
    public Text txtPuntaje;
    private static int puntaje = 0;
    public GameObject manager;
    public void CalcularPuntaje()
    {
        MostrarPreguntasUI preguntas = manager.GetComponent<MostrarPreguntasUI>();

        if (gameObject.CompareTag("A"))
        {
            puntaje += preguntas.itemPregunta[preguntas.numPregunta].valor1;
            txtPuntaje.text = puntaje.ToString();
        }
        else if (gameObject.CompareTag("B"))
        {
            puntaje += preguntas.itemPregunta[preguntas.numPregunta].valor2;
            txtPuntaje.text = puntaje.ToString();
        }
    }
}
