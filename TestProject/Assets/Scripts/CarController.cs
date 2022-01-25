using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class CarController : MonoBehaviour
{
    private ControlSystem control;
    private Camera mainCamera;
    private Animator animator;
    private Collider collider;
    private static readonly int Select = Animator.StringToHash("Select");

    private void Awake()
    {
        control = new ControlSystem();
        mainCamera = Camera.main;
        animator = GetComponent<Animator>();
        collider = GetComponentInChildren<Collider>();
        if (animator == null)
        {
            Debug.LogError("No animator on object");
        }

        control.TouchScreen.click.started += StartAnimation;
        control.TouchScreen.click.canceled += EndAnimation;
    }

    private void StartAnimation(InputAction.CallbackContext ctx)
    {
        Vector2 screenPos = control.TouchScreen.TouchPosition.ReadValue<Vector2>();
        Ray ray = mainCamera.ScreenPointToRay(screenPos);
        if (Physics.Raycast(ray, out var hit))
        {
            if (hit.collider == collider)
            {
                animator.SetBool(Select, true);
            }
        }
    }

    private void EndAnimation(InputAction.CallbackContext ctx)
    {
        animator.SetBool(Select, false);
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
