using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HammerExplosion : MonoBehaviour
{
    public float countdown = 2;
    public ParticleSystem particle;
    private int particleInitializerInt = 0;
    public float maxRadius;
    public float radiusIncreaseSpeed;
    public float explosionRefreshspeed;
    public SphereCollider collider;
    private Coroutine routine;
    [SerializeField]
    private GameObject renderer;
    [SerializeField]
    private BuildCrate buildCrate;
    public void Start()
    {
        particle.Stop();
    }
    void Update()
    {
        countdown -= Time.deltaTime;
        if (countdown <= 0)
        {
            StartCoroutine(Explode());
            renderer.SetActive(false);
            if (particleInitializerInt < 1)
            {
                particle.Play();
                buildCrate.DropCrate();
                particleInitializerInt++;
            }
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
