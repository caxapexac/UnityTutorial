using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptsParameters : MonoBehaviour
{
    public float Speed;

    void Start()
    {
        //Debug.Log("Имя моего объекта: " + gameObject.name);
        //Debug.Log("Позиция: " + transform.localPosition);
        //Debug.Log("Поворот: " + transform.localRotation.eulerAngles);
        //Debug.Log("Размер: " + transform.localScale);
        //Debug.Log("RigidBody mass: " + GetComponent<Rigidbody>().mass);
    }
    
    void Update()
    {
        // Вращаем по координате y со скоростью Speed
        transform.Rotate(Vector3.forward * Speed * Time.deltaTime);

        // Перемещаем объект по нажатию кнопок WASD
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.forward * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.back * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Speed * Time.deltaTime);
        }
    }
}
