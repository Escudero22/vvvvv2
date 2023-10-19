using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AnimationCh : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator _animator;
    private Rigidbody2D _rb;
    private SpriteRenderer _sr;
    private AudioSource _as;
    private bool gravedadInvertida = false;


    // Start is called before the first frame update
    void Awake()
    {

        _animator = gameObject.GetComponent<Animator>();
        _rb = GetComponent<Rigidbody2D>();
        _sr = GetComponent<SpriteRenderer>();
        _as = GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update()
    {
       
        // Detectar la tecla "Escape" para cargar la escena de pausa
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // Cargar la escena de pausa (asegúrate de que la escena "Pausa" esté en la compilación)
            SceneManager.LoadScene("Pausa");
        }
      
    }
   
}
