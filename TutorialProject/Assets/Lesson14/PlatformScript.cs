using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformScript : MonoBehaviour
{
    // Скорость вращения
    public float Speed;
    
    // Направление вращения
    public Vector3 Direction;

    void Update()
    {
        // Если кнопка Q не нажата (опциональная возможность остановить вращение)
        if (Input.GetKeyDown(KeyCode.Q) == false)
        {
            // Вращаем объект
            transform.Rotate(Direction * Speed * Time.deltaTime);
        }
    }
}
