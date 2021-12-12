using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    private Vector3 _previousMousePosition;
    public Transform Level;
    public float sensitivity;
    private void Update()
    {
        //Вращение цилиндра мышкой
        if (Input.GetMouseButton(0))
        {
            Vector3 delta = Input.mousePosition - _previousMousePosition;
            Level.Rotate(0,-delta.x * sensitivity,0);
        }

        //последняя позиция мышы    
        _previousMousePosition = Input.mousePosition;
    }
}
