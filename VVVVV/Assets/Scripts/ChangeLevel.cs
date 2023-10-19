using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeLevel : MonoBehaviour
{
    public static int sceneNum = 1;
    public Transform player;

    /*private void OnTriggerEnter2D(Colider2D other)
    {
        if (other.CompareTag("Player")) {

            SceneManager.LoadScene(sceneNum++);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        switch (collision.gameObject.name)
        {
            case "NextLevel":
                sceneNum++;
                SceneManager.LoadScene(sceneNum);
                player.position = new Vector3(-37, -2, 0);
                DontDestroyOnLoad(gameObject);
                break;
            case "Return Level":
                sceneNum--;
                SceneManager.LoadScene(sceneNum);
                player.position = new Vector3(21, -2, 0);

                break;

        }
    }
}