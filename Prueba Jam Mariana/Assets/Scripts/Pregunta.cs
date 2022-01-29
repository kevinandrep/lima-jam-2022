using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pregunta
{
    //Pregunta
    public string textoPregunta;
    //Respuestas y Valor
    public string textoRespuesta1;
    public int valor1 = 0;
    public string textoRespuesta2;
    public int valor2 = 0;

    public Pregunta(string textopreg, string texto1r, int v1, string texto2r, int v2)
    {
        this.textoPregunta = textopreg;
        this.textoRespuesta1 = texto1r;
        this.textoRespuesta2 = texto2r;
        this.valor1 = v1;
        this.valor2 = v2;
    }
}
