using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnHammer : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject hammer;
    public bool isPlayer2;
    [SerializeField]
    private float time = 3;

    void Update()
    {
        time += Time.deltaTime;
        if (time > 3)
        {
            time = 3;
            if (!isPlayer2)
            {
                if (Input.GetKeyDown(KeyCode.C))
                {
                    DropHammer();
                    time = 0;
                }
            }
            else
            {if (Input.GetKeyDown(KeyCode.KeypadPlus))
                {
                    DropHammer();
                    time = 0;
                }
            } 
        }
    }
    public void DropHammer()
    {
        Vector3 worldPos = gameObject.transform.position;
        Vector3Int cell = tilemap.WorldToCell(worldPos);
        Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);
        Instantiate(hammer, new Vector3(cellCenterPos.x,cellCenterPos.y +0.75f,cellCenterPos.z), hammer.transform.rotation); 
    }

    public float GetTime()
    {
        return time;
    }
}
