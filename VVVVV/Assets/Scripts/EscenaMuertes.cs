using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaMuertes : MonoBehaviour
{
    public void VolverAJugarE()
    {
        // Buscar el objeto del jugador por etiqueta y eliminarlo si se encuentra
        GameObject jugador = GameObject.FindWithTag("Player");
        if (jugador != null)
        {
            Destroy(jugador);
        }
        Debug.Log("destruido");

        // Cargar la escena actual (recargará la misma escena)
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void SalirE()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
