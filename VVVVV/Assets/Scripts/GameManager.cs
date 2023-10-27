using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    private AudioSource audioSource;

    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.Play();
    }
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
}
