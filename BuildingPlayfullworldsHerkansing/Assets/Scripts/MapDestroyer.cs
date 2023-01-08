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
            StartCoroutine(other.GetComponent<BreakableObjectManager>().DestroyBreakableObject());
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
                collider.enabled = false;
                yield return new WaitForSeconds(2f);
                Destroy(this.gameObject);
                yield return new WaitForSeconds(1f);
            }
        }
    }
}
