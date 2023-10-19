using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscenaMuerte : MonoBehaviour
{
   public void VolverAJugar()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+2);
    }
    public void Salir()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
