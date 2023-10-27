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
        if (other.CompareTag("pinchos")|| other.CompareTag("flecha"))
        {
            // Cargar la escena de muerte
           
            SceneManager.LoadScene("DeathScene");
            Destroy(this.gameObject);
            Destroy(gameManager);
            _deathSound.Play();

        }
    }
}
