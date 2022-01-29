using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Pregunta
{
    //Pregunta
    public string textoPregunta;
    //Respuestas
    public string textoRespuesta1;
    public string textoRespuesta2;
    //Valor
    public int correcto = 0;

    public Pregunta(string textopreg, string texto1r, string texto2r, int correcto)
    {
        this.textoPregunta = textopreg;
        this.textoRespuesta1 = texto1r;
        this.textoRespuesta2 = texto2r;
        this.correcto = correcto;
    }
}
