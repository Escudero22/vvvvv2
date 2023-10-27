using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidad de movimiento del enemigo
    public Transform pos1; // Punto "pos1"
    public Transform pos2; // Punto "pos2"
    private Animator anim;
    private bool movingRight = true;

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
            // Cambia de direcci�n al tocar "pos1" o "pos2"
            movingRight = !movingRight;
            Flip();
        }
        //else if (other.CompareTag("ataque"))
        //{
        //    // Realiza la animaci�n de ataque
        //    anim.SetTrigger("Attack");

        //    // Pausa el movimiento durante la animaci�n
        //    moveSpeed = 0f;

        //    // Luego, reanuda el movimiento despu�s de un cierto tiempo
        //    Invoke("ResumeMovement", 1.5f); // Cambia el valor 1.5f al tiempo que necesites para la animaci�n de ataque.
        //}
    }

    void ResumeMovement()
    {
        // Reanuda el movimiento despu�s de la animaci�n de ataque
        moveSpeed = 5f; // Ajusta la velocidad de movimiento seg�n tu juego
    }

    void Flip()
    {
        // Voltea la escala del enemigo para que mire en la direcci�n correcta
        Vector3 scale = transform.localScale;
        scale.x *= -1;
        transform.localScale = scale;
    }
}
