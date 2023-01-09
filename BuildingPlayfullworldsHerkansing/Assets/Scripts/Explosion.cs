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
    private int particleInitializerInt = 0;
    
    public delegate void Explodes();
    public Explodes exploded;
    public void Start()
    {
        particle.Stop();
    }
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        { 
            MapDestroyer mDestroyer = gameObject.GetComponent<MapDestroyer>();
           vCondition.isExploding = true;
           mDestroyer.routine = StartCoroutine(mDestroyer.Explode());
           renderer.enabled = false;
           if (particleInitializerInt < 1)
           {
               particle.Play();
               exploded();
               particleInitializerInt++;
           }
        }
    }


}
