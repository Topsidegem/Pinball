using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlipperIzquierdo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0f, -20f, 0f)));
        }
        if (Input.GetKeyUp(KeyCode.LeftArrow))
        {
            GetComponent<Rigidbody>().MoveRotation(Quaternion.Euler(new Vector3(0f, 0f, 0f)));
        }
    }
}
