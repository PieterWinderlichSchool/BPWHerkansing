using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{

    public float countdown = 2;
    public ParticleSystem particle;
    public MeshRenderer renderer;
    public VictoryCondition vCondition;
    public void Start()
    {
        particle.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        countdown -= Time.deltaTime;

        if (countdown <= 0)
        {
           MapDestroyer mDestroyer = gameObject.GetComponent<MapDestroyer>();
           vCondition.isExploding = true;
           mDestroyer.routine = StartCoroutine(mDestroyer.Explode());
           renderer.enabled = false;
               particle.Play();
              
        }
    }
}
