using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    protected Animator animator;
    protected GameController controller;

    protected virtual void Awake()
    {
        animator = GetComponent<Animator>();
        controller = GetComponent<GameController>();
    }
}
