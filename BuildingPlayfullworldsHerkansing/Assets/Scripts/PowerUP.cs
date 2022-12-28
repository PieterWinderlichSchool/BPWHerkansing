using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUP : MonoBehaviour
{
    public GameObject newObjectOfPowerup;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Entity")
        {
            other.GetComponent<SpawnBomb>().bomb= newObjectOfPowerup;
            Destroy(this.gameObject);
        }
    }
}
