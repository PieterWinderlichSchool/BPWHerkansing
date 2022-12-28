using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasActivator : MonoBehaviour
{
    public List<GameObject> canvasses;

    public void EndGame(int i)
    {
        canvasses[i].SetActive(true);
    }
}
