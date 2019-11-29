using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Vector3 StartPoint;

    private void Start()
    {
        StartPoint = transform.position;
    }

    public void Restart()
    {
        transform.position = StartPoint;
    }
}

