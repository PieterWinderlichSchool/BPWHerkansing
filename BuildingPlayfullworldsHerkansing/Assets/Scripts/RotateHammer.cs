using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateHammer : MonoBehaviour
{
    public float rotatespeed;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0,rotatespeed,0);
    }
}
