using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Victoria : MonoBehaviour
{
    public void Awake()
    {
        Destroy(GameObject.Find("GameManager"));
        Destroy(GameObject.Find("Personaje"));

    }
    public void Jugar()
    {
        SceneManager.LoadScene("Escena1");
    }
    public void Salir()
    {
        Debug.Log("salir");
        Application.Quit();
    }
}
