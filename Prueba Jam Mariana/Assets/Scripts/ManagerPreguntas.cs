using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManagerPreguntas : MonoBehaviour
{
    private float contador = 7f;
    public Slider slider;
    public Text txtPuntaje;
    private int puntaje = 0;

    public GameObject boton01, boton02;

    void Update()
    {
        Cronometro();
    }

    public void Cronometro()
    {
        float nuevoValor = contador - Time.time;
        slider.value = nuevoValor;
    }

    public void CalcularPuntaje()
    {
       if (boton01.CompareTag("A"))
        {
            puntaje += 10;
            txtPuntaje.text = puntaje.ToString();
        }
       if (boton02.CompareTag("B"))
        {
            puntaje -= 10;
            txtPuntaje.text = puntaje.ToString();
        }
    }


}
