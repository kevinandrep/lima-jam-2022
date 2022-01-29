using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MostrarPreguntasUI : MonoBehaviour
{

    public Pregunta[] itemPregunta = new Pregunta[3];
    //public Respuesta[] itemRespuesta = new Respuesta[3];
    public Button botonA, botonB;
    public Text textoPregunta, textoRpta1, textoRpta2;
    public GameObject ui;
    public Slider slider;

    private void Start()
    {
        StartCoroutine(MostrarOcultarBotones());
    }
    IEnumerator MostrarOcultarBotones()
    {
        for (int i = 0; i < 30; i++)
        {
            ui.SetActive(true);
            textoPregunta.text = itemPregunta[i].textoPregunta;
            textoRpta1.text = itemPregunta[i].textoRespuesta1;
            textoRpta2.text = itemPregunta[i].textoRespuesta2;
            yield return new WaitForSeconds(slider.value);
            ui.SetActive(false);
            yield return new WaitForSeconds(2f);
        }
    }
}
