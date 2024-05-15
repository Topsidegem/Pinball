using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumarPuntos : MonoBehaviour
{
    public Puntuacion puntos;

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            puntos.SumarPunto();
        }
    }
}
