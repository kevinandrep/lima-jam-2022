using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Respuestas : MonoBehaviour
{
    public Text txtPuntaje;
    private static int puntaje = 0;
    public void CalcularPuntaje()
    {
        if (gameObject.CompareTag("A"))
        {
            puntaje += 10;
            txtPuntaje.text = puntaje.ToString();
        }
        else if (gameObject.CompareTag("B"))
        {
            puntaje -= 10;
            txtPuntaje.text = puntaje.ToString();
        }
    }
}
