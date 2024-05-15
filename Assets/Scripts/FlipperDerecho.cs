using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperDerecho : MonoBehaviour
{

    void Start()
    {
        
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0f, 20f, 0f)));
        }
        if (Input.GetKeyUp(KeyCode.RightArrow))
        {
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        }
    }
}
