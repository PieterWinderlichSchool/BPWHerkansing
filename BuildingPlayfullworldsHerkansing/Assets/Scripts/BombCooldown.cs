using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BombCooldown : MonoBehaviour
{
    public List<Image> images = new List<Image>();
    public List<SpawnBomb> SpawnBombScripts = new List<SpawnBomb>();
    void Update()
    {
        for (int i = 0; i < SpawnBombScripts.Count; i++)
        {
            images[i].fillAmount = SpawnBombScripts[i].GetTime() / 3;
        }
    }
}
