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
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ControlParticulas(Niebla);
        ControlParticulas(Lluvia);
        float puntajeClamp = Mathf.Clamp(puntaje, 0, 100);
        m_Volume.weight = Mathf.Clamp(Mathf.Abs((puntajeClamp / 100) - 1), 0.001f, 1);
    }

    public void ControlParticulas(ParticleSystem particulas)
    {
        if (particulas.isPlaying)
        {
            if (puntaje > 0) particulas.Stop(true);
        }
        else if (particulas.isStopped)
        {
            if (puntaje < 0) particulas.Play(true);
        }

    }
}