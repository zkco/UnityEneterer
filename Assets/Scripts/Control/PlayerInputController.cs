using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerInputController : GameController
{
    private Camera _camera;

    protected override void Awake()
    {
        base.Awake();
        _camera = Camera.main;
    }

    private void OnMove(InputValue inputValue)
    {
        Vector2 input = inputValue.Get<Vector2>().normalized;
        CallMoveEvent(input);
    }

    private void OnLook(InputValue inputValue)
    {
        Vector2 mousePos = inputValue.Get<Vector2>();
        Vector2 screenSize = _camera.ScreenToWorldPoint(mousePos);
        mousePos = (screenSize - (Vector2)transform.position).normalized;

        CallLookEvent(mousePos);
    }
}
