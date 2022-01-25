using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using TouchPhase = UnityEngine.InputSystem.TouchPhase;

public class CameraController : MonoBehaviour
{
    private ControlSystem control;

    [SerializeField] private float touchSensitivity = 0.5f;

    private void Awake()
    {
        control = new ControlSystem();
    }

    private void Rotate()
    {
        var delta = control.TouchScreen.HoldDirection.ReadValue<Vector2>();
        var XAngle = delta.y*touchSensitivity;
        var YAngle = delta.x*touchSensitivity;
        transform.eulerAngles = new Vector3(transform.eulerAngles.x - XAngle, transform.eulerAngles.y +YAngle, transform.eulerAngles.z);
        
    }

    private void Update()
    {
        if (control.TouchScreen.TouchPhase.ReadValue<TouchPhase>() == TouchPhase.Moved)
        {
            Rotate();
        }
    }

    private void OnEnable()
    {
        control.Enable();
    }

    private void OnDisable()
    {
        control.Disable();
    }
}
