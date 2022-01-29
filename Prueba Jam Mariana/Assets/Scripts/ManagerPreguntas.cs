using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPreguntas : MonoBehaviour
{
    private float contador = 7f;
    public Slider slider;
    
    public GameObject boton01, boton02;

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
            contador = 9f + Time.time;
        }
    }
}
