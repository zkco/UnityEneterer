using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.U2D;

public class CharacterAnimationController : AnimationController
{

    private static readonly int isWalking = Animator.StringToHash("isWalking");

    private readonly float Threshold = 0.5f;


    protected override void Awake()
    {
        base.Awake();
    }

    private void Start()
    {
        controller.OnMoveEvent += Moving;
    }

    private void Moving(Vector2 obj)
    {
        animator.SetBool(isWalking, obj.magnitude > Threshold);
    }


}
