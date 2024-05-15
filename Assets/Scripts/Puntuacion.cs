using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntuacion : MonoBehaviour
{
    public int puntos;
    public int vidas = 3;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vida;
    [SerializeField] GameObject menuPerdiste;

    private void Start()
    {
        puntuacion.text = "Puntos: " + puntos;
        vida.text = "Vidas: " + vidas;
    }

    public void RestarVida()
    {
        vidas--;
        vida.text = "Vidas: " + vidas;
        if (vidas <= 0)
        {
            GameOver();
        }
    }

    public void SumarPunto()
    {
        puntos++;
        puntuacion.text = "Puntos: " + puntos;
    }

    public void GameOver()
    {
        menuPerdiste.SetActive(true);
        Time.timeScale = 0;
    }
}
