using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class SpawnBomb : MonoBehaviour
{

    public Tilemap tilemap;

    public GameObject bomb;

    public bool isPlayer2;
    float time = 0;

    // Update is called once per frame
    void Update()
    {

        time += Time.deltaTime;

        if (time > 3)
        {
            if (!isPlayer2)
            {
                if (Input.GetKeyDown(KeyCode.Space))
                {
                    DropBomb();
                    time = 0;
                }
            }
            else
            {if (Input.GetKeyDown(KeyCode.KeypadEnter))
                {
                    DropBomb();
                    time = 0;
                }
            
            } 
        }
       
       
    }

    public void DropBomb()
    {

        Vector3 worldPos = gameObject.transform.position;

        Vector3Int cell = tilemap.WorldToCell(worldPos);
        Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);
        
        Instantiate(bomb, new Vector3(cellCenterPos.x,cellCenterPos.y +0.25f,cellCenterPos.z), Quaternion.identity); 
    }
}
