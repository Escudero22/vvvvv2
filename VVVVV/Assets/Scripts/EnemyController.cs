using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 33f; // Velocidad de movimiento del enemigo
    public Transform pos1; // Punto "pos1"
    public Transform pos2; // Punto "pos2"
    private Animator anim;
    private bool movingRight = true;
    [SerializeField] private AnimationClip _Atack;
    [SerializeField] bool movingRight;
    public AudioSource ataca;


    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (movingRight)
        {
            transform.Translate(Vector2.right * moveSpeed * Time.deltaTime);
        }
        else
        {
            transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("pos1") || other.CompareTag("pos2"))
        {
            // Cambia de dirección al tocar "pos1" o "pos2"
            movingRight = !movingRight;
            Flip();
        }
        else if (other.CompareTag("ataque"))
        {
            anim.SetBool("ataca", true);

            //    // Realiza la animación de ataque
            //    anim.SetTrigger("atacarenemigo");
            ataca.Play();

            //    // Pausa el movimiento durante la animación
            moveSpeed = 0f;

            //    // Luego, reanuda el movimiento después de un cierto tiempo
                Invoke("ResumeMovement", _Atack.length); // Cambia el valor 1.5f al tiempo que necesites para la animación de ataque.
        }
    }

    void ResumeMovement()
    {
        anim.SetBool("ataca", false);

        // Reanuda el movimiento después de la animación de ataque
        moveSpeed = 33f; // Ajusta la velocidad de movimiento según tu juego
    }

    void Flip()
    {
        // Voltea la escala del enemigo para que mire en la dirección correcta
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
