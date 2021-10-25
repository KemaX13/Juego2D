using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Engine : MonoBehaviour
{
    //Campos privados 
    [SerializeField]
    private float speed;
    [SerializeField]
    private float turnSpeed;
    private InputSystemKeyboard inputSystem;

    void Awake() //Se ejecuta cuando el objeto se activa
    {
        inputSystem = GetComponent<InputSystemKeyboard>();
    }

    void Update()
    {
        transform.position += inputSystem.ver * transform.up * speed * Time.deltaTime;
        transform.Rotate(new Vector3(0, 0, -1) * inputSystem.hor * turnSpeed * Time.deltaTime);
    }
}
