using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Resorte : MonoBehaviour
{
    public GameObject posCarga;
    Vector3 posInicial;
    public Rigidbody resorte;

    void Start()
    {
        posInicial = transform.position;
    }

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            resorte.MovePosition(posCarga.transform.position);
        }
        if (Input.GetKeyUp(KeyCode.Space))
        {
            resorte.MovePosition(posInicial);
        }
    }
}
