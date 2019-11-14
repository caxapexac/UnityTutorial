using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class L12Clock : MonoBehaviour
{
    public int Number;
    public float CurrentTime;
    public string Words;
    public Vector3 Position;

    // Start is called before the first frame update
    void Start()
    {
        CurrentTime = 0;
        Debug.Log("Я запущен");
    }

    // Update is called once per frame
    void Update()
    {
        CurrentTime = CurrentTime + Time.deltaTime;
        Debug.Log("Я выполняюсь " + CurrentTime);
    }
}
