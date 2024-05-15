using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiarPosBola : MonoBehaviour
{
    public Transform posBolainicio;
    public Puntuacion restarVidas;

    public void OnTriggerEnter(Collider other)
    {
        other.transform.position = posBolainicio.position;
        restarVidas.RestarVida();
    }
}
