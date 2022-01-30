using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SfxControl : MonoBehaviour
{
    public ParticleSystem Niebla;
    public ParticleSystem Lluvia;
    public int puntaje = 0;

    public PostProcessVolume m_Volume;

    public AudioSource alluvia, apajaro;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ControlParticulas(Niebla);
        ControlParticulas(Lluvia);
        float puntajeClamp = Mathf.Clamp(Respuestas.puntaje, 0, 100);
        m_Volume.weight = Mathf.Clamp(Mathf.Abs((puntajeClamp / 100 * 6) - 1), 0.001f, 1);
        Debug.Log(Respuestas.puntaje);

        if (Respuestas.puntaje > 0)
        {
            alluvia.Stop();
            if (!apajaro.isPlaying)
            {
                apajaro.Play();
            }
        }
        else if (Respuestas.puntaje <= 0)
        {
            apajaro.Stop();
            if (!alluvia.isPlaying)
            {
                alluvia.Play();
            }
        }
    }

    public void ControlParticulas(ParticleSystem particulas)
    {
        if (particulas.isPlaying)
        {
            if (Respuestas.puntaje > 0) particulas.Stop(true);
        }
        else if (particulas.isStopped)
        {
            if (Respuestas.puntaje < 0) particulas.Play(true);
        }
    }

    //public void ControlAudio()
    //{
    //    if (AudioSource)
    //}
}