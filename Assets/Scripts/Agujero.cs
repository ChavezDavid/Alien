using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Agujero : MonoBehaviour
{
    public Text textoFaltan;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Player player = collision.GetComponent<Player>();
            player.PlayWinSFX();
            if (Puntos.puntos >= 6)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            } else
            {
                textoFaltan.text = "Oh..no, faltan más planetas";
            }
            
        }
    }
}
