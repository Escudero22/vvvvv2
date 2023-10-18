using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlechaMovimiento : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocidad = new Vector2(22f, 0f); // Velocidad de la flecha

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocidad;
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tilemap")) // Colisión con Tilemap
        {
            Destroy(gameObject); // Destruir la flecha al colisionar con el Tilemap
        }
        else if (collision.gameObject.CompareTag("Player")) // Colisión con el jugador
        {
            // Volver al jugador a la escena de muerte
            SceneManager.LoadScene("DeathScene");
        }
    }
}
