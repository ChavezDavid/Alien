using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slide : MonoBehaviour
{
    public Puntos vida;
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {

            Player player = collision.GetComponent<Player>();

            Destroy(gameObject);
            vida.PerderVida();
        }
    }
}
