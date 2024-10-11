using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour
{
    private GameController controller;
    private Rigidbody2D moveRigid;

    private Vector2 moveDirection = Vector2.zero;

    [SerializeField] private DefaultStat stat;

    private void Awake()
    {
        controller = GetComponent<GameController>();
        moveRigid = GetComponent<Rigidbody2D>();
    }

    private void Start()
    {
        controller.OnMoveEvent += Move;
    }

    private void FixedUpdate()
    {
        MoveToDirection(moveDirection);
    }

    private void Move(Vector2 direction)
    {
        moveDirection = direction;
    }

    private void MoveToDirection(Vector2 direction)
    {
        direction = direction * stat.speed;
        moveRigid.velocity = direction;
    }
}
