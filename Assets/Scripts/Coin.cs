using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    public Puntos puntos;
    public Text textoFaltan2;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Player player = collision.GetComponent<Player>();
            player.PlayCoinSFX();

            Destroy(gameObject);
            puntos.GanarPunto();
            textoFaltan2.text = "Muajaja, a conquistar planetas!";
        }
    }
}
