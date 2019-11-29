using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// Скрипт для прилипания игрока к платформе
public class PlatformAttacher : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Чтобы к платформе прилипал только игрок
        {
            other.transform.parent = transform; // transform - позиция платформы
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player")) // Чтобы к платформе прилипал только игрок
        {
            other.transform.parent = null; //См. иерархию, чтобы понять что происходит
        }
    }
}
