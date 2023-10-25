using System.Collections;
using System.Collections.Generic;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class SpawnPlayer : MonoBehaviour
{
    public Transform playerTransform;
    public GameObject spawnPointEmpty;
    bool isNextScene = true;

    private void OnLevelWasLoaded(int level)
    {
        playerTransform = transform;
        string targetObjectName = isNextScene ? "Empty" : "Empty2";
        spawnPointEmpty = GameObject.Find(targetObjectName);

        Vector3 newPosition = playerTransform.position;
        newPosition.x = spawnPointEmpty.transform.position.x;
        playerTransform.position = newPosition;


        Debug.Log(isNextScene);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        isNextScene = collision.CompareTag("NextLevel");
    }
}

