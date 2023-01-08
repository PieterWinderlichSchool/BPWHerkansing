using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextDisplay : MonoBehaviour
{

    public List<GameObject> texts = new List<GameObject>();
    public List<SpawnBomb> SpawnBombScripts = new List<SpawnBomb>();
    
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < SpawnBombScripts.Count; i++)
        {
            SpawnBombScripts[i].signalUpgrade += UpdateUI;
            
        }
    }

    public void UpdateUI(bool isPlayer2)
    {
        if (!isPlayer2)
        {
            texts[0].SetActive(true);
        }
        else
        {
            texts[1].SetActive(true);
        }
    }
}
