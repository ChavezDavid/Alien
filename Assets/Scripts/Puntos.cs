using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    public static int puntos = 0;
    public Text textoPunto;
    // Start is called before the first frame update
    void Start()
    {
        ActualizarMarcadorPuntos();
    }
    void ActualizarMarcadorPuntos()
    {
        textoPunto.text = "Puntos: " + Puntos.puntos;
    }
    public void GanarPunto()
    {
        Puntos.puntos++;
        ActualizarMarcadorPuntos();
    }

}
