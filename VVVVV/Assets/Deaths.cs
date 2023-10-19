using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            // Cargar la escena de muerte
            SceneManager.LoadScene("DeathScene");
        }
    }
}