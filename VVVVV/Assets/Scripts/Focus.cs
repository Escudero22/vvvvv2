using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Focus : MonoBehaviour
{
    private Transform _transform;
    [SerializeField] private GameObject _focusedObject;
    // Start is called before the first frame update
    void Start()
    {
        _transform = GetComponent<Transform>();   
    }

    // Update is called once per frame
    void Update()
    {
        _transform.position=_focusedObject.transform.position;
    }
}
