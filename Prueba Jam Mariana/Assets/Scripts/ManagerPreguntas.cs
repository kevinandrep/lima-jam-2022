using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPreguntas : MonoBehaviour
{
    public float timePerPregunta = 7f;
    public float delayEntrePreguntas = 2f;
    private float contador = 0f;
    public Slider slider;
    
    public GameObject boton01, boton02;

    private void Start()
    {
        slider.maxValue = timePerPregunta;
        slider.value = timePerPregunta;
        contador = timePerPregunta;
    }

    void Update()
    {
        Cronometro();
    }

    public void Cronometro()
    {
        float nuevoValor = contador - Time.time;
        slider.value = nuevoValor;
        if (slider.value == 0)
        {
            //Resetea(?) el slider
            contador = timePerPregunta + delayEntrePreguntas + Time.time;
        }
    }
}