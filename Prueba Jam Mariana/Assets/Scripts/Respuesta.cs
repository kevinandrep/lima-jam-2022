using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Respuesta
{
    public string textoRespuesta1;
    public string textoRespuesta2;
    public int correcto = 0;

    public Respuesta(string texto1, string texto2, int correcto)
    {
        this.textoRespuesta1 = texto1;
        this.textoRespuesta2 = texto2;
        this.correcto = correcto;
    }
}
