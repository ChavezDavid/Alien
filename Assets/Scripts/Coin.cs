using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public Puntos puntos;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            
            Player player = collision.GetComponent<Player>();
            player.PlayCoinSFX();

            Destroy(gameObject);
            puntos.GanarPunto();
        }
    }
}
