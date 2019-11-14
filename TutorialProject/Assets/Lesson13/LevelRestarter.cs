using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelRestarter : MonoBehaviour
{
    // Максимальное возможное время игры
    public float MaxTime;

    // Стартовая точка
    private Vector3 StartPoint;

    // Текущее время игры
    private float currentTime;

    void Start ()
    {
        // Устанавливаем стартовую точку в том месте, где находимся в начале игры
        StartPoint = transform.position;

        // Обнуляем время в начале игры
        currentTime = 0;
    }
    
    // Каждый кадр
    void Update()
    {
        // Обновляем время игры
        // Сокращённая запись currentTime = currentTime + Time.deltaTime;
        currentTime += Time.deltaTime;

        // Если время игры стало равно максимальному возможному
        if (currentTime > MaxTime)
        {
            // Говорим, что время вышло
            Debug.Log("Время вышло, рестарт...");

            // Перезагружаемся
            // transform.position - позиция объекта, на котором висит скрипт
            transform.position = StartPoint;

            // Обнуляем время
            currentTime = 0;
        }
    }
}
