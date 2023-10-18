using System.Collections;
using UnityEngine;

public class GeneradorFlechasArriba : MonoBehaviour
{
    public GameObject flechaPrefab;
    public float intervalo = 4f;

    private void Start()
    {
        StartCoroutine(GenerarFlechasConRetardo());
    }

    IEnumerator GenerarFlechasConRetardo()
    {
        yield return new WaitForSeconds(0.5f); // Esperar 3 segundos antes de generar la primera flecha

        while (true)
        {

            GameObject flecha = Instantiate(flechaPrefab, transform.position, Quaternion.identity);


            yield return new WaitForSeconds(intervalo);
        }
    }
}
