using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Pausa : MonoBehaviour
{
    public void JugarDeNuevo()
    {
        SceneManager.LoadScene("Escena1");
    }
    public void Salir()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
