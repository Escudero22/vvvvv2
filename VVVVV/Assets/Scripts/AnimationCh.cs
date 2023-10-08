using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
        //Personaje se mueve a la derecha
        if (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            _rb.velocity = new Vector2(10, 0);
            _animator.SetBool("secorre", true);
            _sr.flipX = false;

        }
        if (Input.GetKeyUp(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D))
        {
            _rb.velocity = Vector2.zero;
            _animator.SetBool("secorre", false);

        }
        //Personaje se mueve a la izquierda
        if (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            _rb.velocity = new Vector2(-10, 0);
            _sr.flipX = true;
            _animator.SetBool("secorre", true);

        }
        if (Input.GetKeyUp(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A))
        {
            _rb.velocity = Vector2.zero;
            _animator.SetBool("secorre", false);

        }
        //personaje se mueve hacia arriba
        if (Input.GetKeyDown(KeyCode.Space))
        {
            gravedadInvertida = !gravedadInvertida;
            if (gravedadInvertida)
            {
                // Cambiar la gravedad hacia abajo
                _rb.gravityScale = 5;
                _sr.flipY = false;

            }
            else
            {
                // Cambiar la gravedad hacia arriba
                _rb.gravityScale = -5;
                _sr.flipY=true;


            }


        }
    }
}
