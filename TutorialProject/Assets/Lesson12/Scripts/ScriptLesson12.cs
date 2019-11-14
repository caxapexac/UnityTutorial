using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptLesson12 : MonoBehaviour
{
    // public - публичный доступ, то есть переменная доступна для изменений из юнити
    // string - строка символов
    // Name - название переменной
    public string Name;

    // int - целое число
    public int Speed;

    // private - нельзя изменить в инспекторе
    private float currentTime;

    // Вызывается только при запуске скрипта
    void Start()
    {
        //Debug.Log(Name + " стартовал");

        currentTime = 0;
    }

    // Вызывается каждый кадр (примерно 60 раз в секунду)
    void Update()
    {
        // transform - положение объекта
        // transform.Translate(x) - перемещение объекта на x
        // Vector3.forward - вектор, указывающий движение вперёд
        //transform.Translate(Vector3.forward * Speed);
        //Debug.Log(Name + " обновляется");

        //Debug.Log(Time.deltaTime);

        // Прибавляем к сумме времен время текущего кадра
        currentTime = currentTime + Time.deltaTime;
        // И выводим его
        Debug.Log(currentTime);
    }
}
