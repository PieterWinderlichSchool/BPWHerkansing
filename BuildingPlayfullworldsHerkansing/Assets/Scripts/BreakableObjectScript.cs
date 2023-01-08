using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BreakableObjectScript : MonoBehaviour
{
    public GameObject powerup;
    public BreakableObjectManager manager;
    public float spawnChance;
    private void Start()
    {
        manager.isDestroyed += spawnPowerup;
    }

    private void spawnPowerup(){
        float randomNumber = Random.value;
            if (randomNumber > spawnChance)
            {
                GameObject powerUp = Instantiate(powerup, transform.position, Quaternion.identity);
                powerUp.transform.rotation = Quaternion.Euler(0, 0, 90);
                powerUp.transform.position = new Vector3(transform.position.x, transform.position.y-0.5f, transform.position.z);
            }
    }
}
