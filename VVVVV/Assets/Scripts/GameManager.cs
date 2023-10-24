using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform player;
    public static GameManager gameManager;

    private void Awake()
    {
        //    if (GameManager.gameManager != null && GameManager.gameManager != this)
        //        Destroy(this.gameObject);
        //    GameManager.gameManager = this;
        if (GameManager.gameManager == null)
            GameManager.gameManager = this;
        else
        {
            Destroy(this.gameObject);
        }

        DontDestroyOnLoad(gameObject);

    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel"))
        {

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            

        }
       

        if (collision.gameObject.CompareTag("ReturnLevel"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
        ////
    }

}
