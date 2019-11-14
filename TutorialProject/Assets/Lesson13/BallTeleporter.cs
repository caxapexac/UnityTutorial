using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTeleporter : MonoBehaviour
{
    // Подключаем сюда конечную точку телепорта
    public Transform Target;

    // Подключаем ссылку на партиклы
    public ParticleSystem Particles;

    // При входе объекта в триггер
    void OnTriggerEnter(Collider other)
    {
        // Телепортировать объект на конечную точку
        other.transform.position = Target.transform.position;
        // Перемещаем партиклы к игроку
        Particles.transform.position = Target.transform.position;
        // Запускаем их
        Particles.Play();
    }
}
