using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour
{
    public GameObject gameManager;
    private AudioSource _deathSound; 

    private void Start()
    {
        _deathSound = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("pinchos")|| other.CompareTag("flecha")|| other.CompareTag("enemigo"))
        {
            // Cargar la escena de muerte
            Destroy(this.gameObject);
            SceneManager.LoadScene("DeathScene");
            Destroy(gameManager);
            _deathSound.Play();

        }
    }
}
