using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlechaMovimiento : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocidad = new Vector2(60f, 0f); // Velocidad de la flecha
    private bool haColisionado = false;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocidad;
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("finalflecha")) 
        {
            haColisionado = true;
        }
        else if (collider.CompareTag("Player")) // Colisión con el jugador
        {
            // Volver al jugador a la escena de muerte
            SceneManager.LoadScene("DeathScene");
        }
    }
    void Update()
    {
        if (haColisionado)
        {
            // Vuelve la flecha a la posición del generadorflecha
            transform.position = GameObject.Find("GenerarFlechas").transform.position;
            rb.velocity = velocidad; // Reinicia la velocidad
            haColisionado = false;
        }
    }
}
