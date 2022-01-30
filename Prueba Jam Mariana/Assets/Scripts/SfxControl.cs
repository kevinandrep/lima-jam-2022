using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class SfxControl : MonoBehaviour
{
    public ParticleSystem Niebla;
    public ParticleSystem Lluvia;
    public int puntaje = 0;

    public GameObject dsa;

    public PostProcessVolume m_Volume;
    void Start()
    {

    }
    // Update is called once per frame
    void Update()
    {
        ControlParticulas(Niebla);
        ControlParticulas(Lluvia);
        m_Volume.weight = Mathf.Abs((float.Parse(puntaje.ToString()) / 100) - 1);
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

        dsa.SetActive(true);
    }
}