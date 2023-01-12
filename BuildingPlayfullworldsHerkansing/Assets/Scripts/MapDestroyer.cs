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
    public GameObject sphere;
    public Renderer matToChangeSphere;
    [SerializeField]
    private float colorValueToAdd;

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
                sphere.transform.localScale = new Vector3(collider.radius*2f,collider.radius*2f,collider.radius*2f);
                ChangeBlastapearance();
                yield return new WaitForSeconds(explosionRefreshspeed);
            }
            else
            {
                routine = null;
                collider.enabled = false;
                yield return new WaitForSeconds(0.3f);
                sphere.SetActive(false);
                yield return new WaitForSeconds(2f);
                Destroy(this.gameObject);
                yield return new WaitForSeconds(1f);
            }
        }
    }

    public void ChangeBlastapearance()
    {
        Color color = matToChangeSphere.material.color;
        if (color.a <= 0.1f)
        {
            color.a = 0.1f;
            return;
        }
        else
        {
            color.a -= colorValueToAdd; 
        }
        matToChangeSphere.material.SetColor("_Color", color);
    }
}
