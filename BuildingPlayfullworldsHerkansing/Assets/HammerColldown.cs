using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HammerColldown : MonoBehaviour
{
    public List<Image> images = new List<Image>();
    public List<SpawnHammer> SpawnCrateScript = new List<SpawnHammer>();
    void Update()
    {
        for (int i = 0; i < SpawnCrateScript.Count; i++)
        {
            images[i].fillAmount = SpawnCrateScript[i].GetTime() / 3;
        }
    }
}
