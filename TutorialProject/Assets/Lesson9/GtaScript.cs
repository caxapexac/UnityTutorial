using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Cameras;
using UnityStandardAssets.Vehicles.Car;

public class GtaScript : MonoBehaviour
{
    public CarAIControl AiCar;
    public CarUserControl UserCar;
    public AutoCam Cam;

    // Объект, который будет показывать, в какую точку игрок вылазит из машины
    public Transform Anchor;

    void Start()
    {
        // Выключаем логику машин
        AiCar.enabled = false;
        UserCar.enabled = false;
        // Скрипт висит на игроке - говорим камере следить за ним
        Cam.SetTarget(transform);
    }

    // Встроенная функция, срабатывает, когда входим в триггер-коллайдер
    void OnTriggerEnter(Collider other)
    {
        // Проверяем, что столкнулись с нашей машиной
        if (other.gameObject == UserCar.gameObject)
        {
            // Включаем машины
            AiCar.enabled = true;
            UserCar.enabled = true;
            // Перенаправляем камеру на машину
            Cam.SetTarget(UserCar.transform);
            // Выключаем игрока от третьего лица
            gameObject.SetActive(false);
        }
    }

    public void CarOut()
    {
        // Перемещаем игрока к объекту-якорю
        transform.position = Anchor.position;
        // Включаем игрока
        gameObject.SetActive(true);
        // Выключаем машину игрока
        UserCar.enabled = false;
        // Настраиваем камеру на игрока
        Cam.SetTarget(transform);
    }
}

