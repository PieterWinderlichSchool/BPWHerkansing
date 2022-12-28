using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VictoryCondition : MonoBehaviour
{

    public bool isExploding = false;
    public CanvasActivator canvas;

    public void Start()
    {
        canvas = GameObject.FindWithTag("Canvass").GetComponent<CanvasActivator>();
    }


    private void OnTriggerStay(Collider other)
    {
        if (isExploding)
        {
            if (other.tag == "Entity")
            {
                if (other.GetComponent<PlayerMovement>().isPlayer2)
                {
                    canvas.EndGame(1);
                }
                else
                {
                    canvas.EndGame(0);
                }

                Time.timeScale = 0;
                //Destroy(other.gameObject);
            }
        }
    }
}
