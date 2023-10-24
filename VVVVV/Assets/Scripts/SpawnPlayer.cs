using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Transform _transform;
    public GameObject spawnPointEmpty; // Asigna esto en el Inspector de Unity
    public GameObject spawnPointEmpty2; // Asigna esto en el Inspector de Unity
    bool NextScene = true;

    private void OnLevelWasLoaded(int level)
    {
        _transform = GetComponent<Transform>();

        spawnPointEmpty = GameObject.Find("Empty");
        spawnPointEmpty2 = GameObject.Find("Empty2");

        if (NextScene == true)
        {
            Vector3 newPosition = _transform.position;
            newPosition.x = spawnPointEmpty.transform.position.x;
            _transform.position = newPosition;

        }
        else _transform.position = spawnPointEmpty2.transform.position;

        Debug.Log(NextScene);
        //if (NextScene == true)
        //{
        //    Vector3 newPosition = _transform.position;
        //    newPosition.y = spawnPointEmpty.transform.position.y;
        //    _transform.position = newPosition;
        //}
        //else
        //{
        //    Vector3 newPosition = _transform.position;
        //    newPosition.y = spawnPointEmpty2.transform.position.y;
        //    _transform.position = newPosition;
        //}
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("NextLevel")) NextScene = true;
        else if (collision.gameObject.CompareTag("ReturnLevel")) NextScene = false;

    }

    //private void Start()
    //{
    //    GameObject player = GameObject.FindGameObjectWithTag("Player");

    //    if (player != null)
    //    {
    //        if (NextScene) {
    //            if (gameObject.CompareTag("Empty"))
    //            {
    //                player.transform.position = spawnPointEmpty.position;
    //            }

    //        }
    //        else if (gameObject.CompareTag("Empty2"))
    //        {
    //            player.transform.position = spawnPointEmpty2.position;
    //        }
    //        NextScene=!NextScene;
    //    }
    //    else
    //    {
    //        Debug.LogError("No se encontró un objeto con la etiqueta 'Player'. Asegúrate de que el personaje tenga la etiqueta correcta.");
    //    }
    //}
}
