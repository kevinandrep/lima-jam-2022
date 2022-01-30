using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respuestas : MonoBehaviour
{
    public Text txtPuntaje;
    public static int puntaje = 0;
    public GameObject manager;
    public void CalcularPuntaje()
    {
        MostrarPreguntasUI preguntas = manager.GetComponent<MostrarPreguntasUI>();
        ManagerPreguntas managerPreguntas = manager.GetComponent<ManagerPreguntas>();

        if (gameObject.CompareTag("A"))
        {
            puntaje += preguntas.itemPregunta[preguntas.numPregunta].valor1;
            txtPuntaje.text = puntaje.ToString();
            preguntas.numPregunta = preguntas.itemPregunta[preguntas.numPregunta].teLLevaA1 - 1;
        }
        else if (gameObject.CompareTag("B"))
        {
            puntaje += preguntas.itemPregunta[preguntas.numPregunta].valor2;
            txtPuntaje.text = puntaje.ToString();
            preguntas.numPregunta = preguntas.itemPregunta[preguntas.numPregunta].teLLevaA2 - 1;
        }
        Debug.Log(puntaje);
        managerPreguntas.offset += managerPreguntas.slider.value;
    }
}
