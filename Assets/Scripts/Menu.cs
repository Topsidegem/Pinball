using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using TMPro;

public class Menu : MonoBehaviour
{
    [SerializeField] GameObject menu;
    [SerializeField] GameObject menuPerdiste;
    public TextMeshProUGUI puntuacion;
    public TextMeshProUGUI vida;
    public Puntuacion vidasYPuntos;

    void Start()
    {
        Time.timeScale = 0;
    }

    public void Iniciar()
    {
        vidasYPuntos.vidas = 3;
        vidasYPuntos.puntos = 0;
        vida.text = "Vidas: " + vidasYPuntos.vidas;
        puntuacion.text = "Puntos: " + vidasYPuntos.puntos;
        menu.SetActive(false);
        Time.timeScale = 1;
    }

    public void Reiniciar()
    {
        vidasYPuntos.vidas = 3;
        vidasYPuntos.puntos = 0;
        vida.text = "Vidas: " + vidasYPuntos.vidas;
        puntuacion.text = "Puntos: " + vidasYPuntos.puntos;
        menuPerdiste.SetActive(false);
        Time.timeScale = 1;
    }

    public void IrALMenu()
    {
        menuPerdiste.SetActive(false);
        menu.SetActive(true);
    }

    public void Salir()
    {
        EditorApplication.isPlaying = false;
    }
}
