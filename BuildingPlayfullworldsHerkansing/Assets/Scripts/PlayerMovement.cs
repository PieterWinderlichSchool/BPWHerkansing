using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private float speed;
    [SerializeField]
    private float rotationSpeed;

    private float newRot;
    public bool isPlayer2 = false;

    // Update is called once per frame
    void Update()
    {
        if (isPlayer2)
        {
            float horizontal = Input.GetAxisRaw("Rotation");
            float vertical = Input.GetAxisRaw("Vertical");
            //transform.
            transform.Rotate(0,horizontal*rotationSpeed*Time.deltaTime,0);
            transform.Translate(new Vector3(0,0,vertical * speed)*Time.deltaTime, Space.Self);
        }
        else
        {
            float horizontal = Input.GetAxisRaw("Rotation1");
            float vertical = Input.GetAxisRaw("Vertical1");
            transform.Rotate(0,horizontal*rotationSpeed*Time.deltaTime,0);
            transform.Translate(new Vector3(0,0,vertical * speed)*Time.deltaTime, Space.Self);
        }
            
        
    }
}
