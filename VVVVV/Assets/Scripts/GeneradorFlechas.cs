using System.Collections;
using UnityEngine;

public class GeneradorFlechas : MonoBehaviour
{
    public GameObject flechaPrefab;
    public float intervalo = 3f;

    private void Start()
    {
        StartCoroutine(GenerarFlechasConRetardo());
    }

    IEnumerator GenerarFlechasConRetardo()
    {

        while (true)
        {
            GameObject flecha = Instantiate(flechaPrefab, transform.position, Quaternion.identity);


            yield return new WaitForSeconds(intervalo);
        }
    }
}
