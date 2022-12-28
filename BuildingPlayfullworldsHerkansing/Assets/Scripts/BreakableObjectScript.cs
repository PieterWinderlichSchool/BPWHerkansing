using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class BreakableObjectScript : MonoBehaviour
{
    public GameObject powerup;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bomb")
        {
            float randomNumber = Random.value;
            if (randomNumber > 0.7f)
            {
                GameObject powerUp = Instantiate(powerup, transform.position, Quaternion.identity);
                powerUp.transform.rotation = Quaternion.Euler(0, 0, 90);
                powerUp.transform.position =
                    new Vector3(transform.position.x, transform.position.y-0.5f, transform.position.z);
            }
            Destroy(this.gameObject);
        }
    }
}
