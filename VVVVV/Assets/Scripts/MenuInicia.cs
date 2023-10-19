using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicia : MonoBehaviour
{
   public void JugarM()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    public void SalirI()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
