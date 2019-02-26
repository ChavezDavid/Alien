using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Slide : MonoBehaviour
{
    public Puntos vida;
    public Text textoFaltan2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Player player = collision.GetComponent<Player>();
            
            player.PlayDeadSFX();
            Destroy(gameObject);
            vida.PerderVida();
            textoFaltan2.text = "Aush, Eso dolio mucho!";
            if (Puntos.vida == 0)
            {
                SceneManager.LoadScene("Gameover");
                Puntos.puntos = 0;
                Puntos.vida = 2;
            }
        }
    }
}
