using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public static int vida = 4;
    public Text textoPunto;
    public Text textoVida;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorPuntos();
        ActualizarVida();
    }
    void ActualizarMarcadorPuntos()
    {
        textoPunto.text = "Puntos: " + Puntos.puntos;
    }
    void ActualizarVida()
    {
        textoVida.text = "Vida: " + Puntos.vida;
    }
    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
    }
    public void PerderVida()
    {
        Puntos.vida++;
        ActualizarVida();
    }
}
