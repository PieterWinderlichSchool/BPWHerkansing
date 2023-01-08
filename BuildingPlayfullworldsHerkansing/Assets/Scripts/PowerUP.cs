using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    public GameObject newObjectOfPowerup;
        
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Entity")
        {
            other.GetComponent<SpawnBomb>().bomb= newObjectOfPowerup;
            other.GetComponent<SpawnBomb>().returnPlayer();
            Destroy(this.gameObject);
        }
    }
}
