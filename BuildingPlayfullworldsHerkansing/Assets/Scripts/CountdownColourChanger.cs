using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CountdownColourChanger : MonoBehaviour
{
[SerializeField]
    private Renderer matToChange;
[SerializeField]
    private Explosion countdownScript;

    [SerializeField]
    private float colorValueToAdd;
    [SerializeField]
    private float waitForSecondsValue;
    void Start()
    {
        StartCoroutine(ChangeColor());
    }


    public IEnumerator ChangeColor()
    {
        Color color = matToChange.material.color;
        color = Color.white;
        while (true)
        {
            color.r += colorValueToAdd;
            
            matToChange.material.SetColor("_Color", color);
            yield return new WaitForSeconds(waitForSecondsValue);
        }
    }
}
