using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Tilemaps;

public class MapDestroyer : MonoBehaviour
{
    public SphereCollider collider;

    public Coroutine routine;

    public float maxRadius;
    public float radiusIncreaseSpeed;
    public float explosionRefreshspeed;
    private void OnTriggerEnter(Collider other)
    { 
        if (other.tag == "Breakable")
        {
            Destroy(other.gameObject);
        }
    }

    public IEnumerator Explode()
    {
        while (true)
        {
            if (collider.radius <= maxRadius)
            {
                collider.radius += radiusIncreaseSpeed;
                yield return new WaitForSeconds(explosionRefreshspeed);
            }
            else
            {
                routine = null;
                Destroy(this.gameObject);
                yield return new WaitForSeconds(1f);
            }
            
        }

       
    }
}
