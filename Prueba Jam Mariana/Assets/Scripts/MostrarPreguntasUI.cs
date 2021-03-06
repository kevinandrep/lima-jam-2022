using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MostrarPreguntasUI : MonoBehaviour
{

    public Pregunta[] itemPregunta = new Pregunta[3];
    //public Respuesta[] itemRespuesta = new Respuesta[3];
    public Button botonA, botonB;
    public Text textoPregunta, textoRpta1, textoRpta2;
    public GameObject ui;
    public Slider slider;
    [HideInInspector] public int numPregunta;

    private void Start()
    {
        numPregunta = 0;
        StartCoroutine(MostrarOcultarBotones());
    }
    IEnumerator MostrarOcultarBotones()
    {
        while (numPregunta < 15)
        {
            ui.SetActive(true);
            textoPregunta.text = itemPregunta[numPregunta].textoPregunta;
            textoRpta1.text = itemPregunta[numPregunta].textoRespuesta1;
            textoRpta2.text = itemPregunta[numPregunta].textoRespuesta2;
            yield return new WaitUntil(() => slider.value == 0);
            ui.SetActive(false);
            yield return new WaitForSeconds(GetComponent<ManagerPreguntas>().delayEntrePreguntas);
        }

        if (Respuestas.puntaje > 0) SceneManager.LoadScene("GameOverBueno");
        else SceneManager.LoadScene("GameOverMalo");
        Respuestas.puntaje = 0;
    }
}
