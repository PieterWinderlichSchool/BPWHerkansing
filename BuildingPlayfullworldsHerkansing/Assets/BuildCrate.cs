using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class BuildCrate : MonoBehaviour
{
    public Tilemap tilemap;
    public GameObject crate;
    // Start is called before the first frame update
    void Start()
    {
        tilemap = GameObject.FindWithTag("Tilemap").GetComponent<Tilemap>();
    }
    public void DropCrate()
        {
            Vector3 worldPos = gameObject.transform.position;
            Vector3Int cell = tilemap.WorldToCell(worldPos);
            Vector3 cellCenterPos = tilemap.GetCellCenterWorld(cell);
            Instantiate(crate, new Vector3(cellCenterPos.x,cellCenterPos.y +1.5f,cellCenterPos.z), Quaternion.identity); 
        }
}
