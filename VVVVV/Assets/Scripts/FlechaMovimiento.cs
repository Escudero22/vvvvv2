using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FlechaMovimiento : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 velocidad = new Vector2(60f, 0f); // Velocidad de la flecha
    private bool haColisionado = false;
    private AudioSource flechaAudio; // Referencia al componente AudioSource

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = velocidad;

        // Obtén la referencia al componente AudioSource
        flechaAudio = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag("finalflecha"))
        {
            haColisionado = true;
            flechaAudio.Stop(); // Detén el sonido cuando llega al final
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

            flechaAudio.Play(); // Reproduce el sonido al volver al principio
        }
    }
}
