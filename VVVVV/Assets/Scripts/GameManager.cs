using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public static GameManager gameManager;

    //private void Awake()
    //{
    //    if (GameManager.gameManager != null && GameManager.gameManager != this)
    //        Destroy(this.gameObject);
    //    GameManager.gameManager = this;

    //}
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // Encuentra el objeto Empty en la escena actual y toma su posici�n
            GameObject emptyObject = GameObject.Find("Empty");
            if (emptyObject != null)
            {
                Vector3 emptyPosition = emptyObject.transform.position;
                // Solo ajusta la coordenada X del jugador
                player.position = new Vector3(emptyPosition.x, player.position.y, player.position.z);
            }
            else
            {
                Debug.LogError("No se encontr� un objeto Empty con el nombre 'Empty' en la escena actual.");
            }
            //// Imprimir el nombre de la escena actual
            Debug.Log("Nombre de la escena actual: " + SceneManager.GetActiveScene().name);
            DontDestroyOnLoad(gameObject);

        }
        if (collision.gameObject.CompareTag("NextLevelUp"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            // Encuentra el objeto Empty en la escena actual y toma su posici�n
            GameObject emptyObject = GameObject.Find("Empty");
            if (emptyObject != null)
            {
                Vector3 emptyPosition = emptyObject.transform.position;
                // Solo ajusta la coordenada X del jugador
                player.position = new Vector3(player.position.x, emptyPosition.y, player.position.z);
            }
            else
            {
                Debug.LogError("No se encontr� un objeto Empty con el nombre 'Empty' en la escena actual.");
            }
            //// Imprimir el nombre de la escena actual
            Debug.Log("Nombre de la escena actual: " + SceneManager.GetActiveScene().name);
            DontDestroyOnLoad(gameObject);
        }

        if (collision.gameObject.CompareTag("ReturnLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);


                // Encuentra el objeto Empty en la escena actual y toma su posici�n
                GameObject emptyObject = GameObject.Find("Empty2");
                if (emptyObject != null)
                {

                    Vector3 emptyPosition = emptyObject.transform.position;
                    // Solo ajusta la coordenada X del jugador
                    player.position = new Vector3(emptyPosition.x, player.position.y, player.position.z);

                }
                else
                {
                    Debug.LogError("No se encontr� un objeto Empty con el nombre 'Empty' en la escena actual.");
                }
            
            // Gira al jugador en el eje X
            // Encuentra el objeto Empty en la escena actual y toma su posici�n
        }
        if (collision.gameObject.CompareTag("ReturnLevelDown"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);

            GameObject emptyObject = GameObject.Find("Empty2");
            if (emptyObject != null)
            {
                Vector3 emptyPosition = emptyObject.transform.position;
                // Solo ajusta la coordenada X del jugador
                player.position = new Vector3(player.position.x, emptyPosition.y, player.position.z);
            }
            else
            {
                Debug.LogError("No se encontr� un objeto Empty con el nombre 'Empty' en la escena actual.");
            }
            //// Imprimir el nombre de la escena actual
            Debug.Log("Nombre de la escena actual: " + SceneManager.GetActiveScene().name);
            DontDestroyOnLoad(gameObject);
        }

    }

}
