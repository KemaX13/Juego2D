using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PartSystem : MonoBehaviour
{
    [SerializeField]
    private ParticleSystem Jet;
    [SerializeField]
    private ParticleSystem ExpParticle;

    void OnEnable()
    {
        GetComponent<InputSystemKeyboard>().JetPlay += JetEngineP;
        GetComponent<InputSystemKeyboard>().JetStop += JetEngineS;
    }
    void OnDisable()
    {
        GetComponent<InputSystemKeyboard>().JetPlay -= JetEngineP;
        GetComponent<InputSystemKeyboard>().JetStop -= JetEngineS;
    }

    private void JetEngineP()
    {
        Jet.Play();
    }

    private void JetEngineS()
    {
        Jet.Stop();
    }

    private void OnTriggerEnter2D()
    {
        if (GetComponent<HealthSystem>().health <= 0)
        {
            var e = Instantiate(ExpParticle, transform.position, Quaternion.identity);
            e.Play();
        }
    }
}