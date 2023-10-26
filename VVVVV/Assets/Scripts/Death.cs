using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject gameManager;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("pinchos")|| other.CompareTag("flecha"))
        {
            // Cargar la escena de muerte
           
            SceneManager.LoadScene("DeathScene");
            Destroy(this.gameObject);
            Destroy(gameManager);
        }
    }
}
