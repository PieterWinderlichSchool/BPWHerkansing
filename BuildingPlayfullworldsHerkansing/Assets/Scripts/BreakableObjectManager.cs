using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreakableObjectManager : MonoBehaviour
{
  public float timeBeforeDestruction;

  public delegate void IsDestroyed();

  public MeshRenderer renderer;
  public IsDestroyed isDestroyed;
  
  public IEnumerator DestroyBreakableObject()
  {
    while (true)
    {
      isDestroyed();
      renderer.enabled = false;
      yield return new WaitForSeconds(timeBeforeDestruction);
      Destroy(this.gameObject);
      yield return new WaitForSeconds(2f);
    }
  }
}
