using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MovementController))]
public class MovementLogic : MonoBehaviour
{
    public bool WantsToMoveRight { get; set; } = false;
    public bool WantsToMoveLeft { get; set; } = false;
    public bool WantsToJump { get; set; } = false;

    [SerializeField]
    float jumpForce = 20f;

    [SerializeField]
    float runForce = 1f;

    MovementController movementLogic;

    void Awake()
    {
        movementLogic = GetComponent<MovementController>();
    }

    void Update()
    {
        Jump();
    }

    private void Jump()
    {
        if (WantsToJump)
        {
            movementLogic.Jump(jumpForce);
            WantsToJump = false;
        }
    }

    void FixedUpdate()
    {
        MoveHorizontally();
    }

    private void MoveHorizontally()
    {
        if (WantsToMoveRight && WantsToMoveLeft)
        {
            movementLogic.Run(0);
        }
        else if (WantsToMoveRight)
        {
            movementLogic.Run(runForce);
        }
        else if (WantsToMoveLeft)
        {
            movementLogic.Run(-runForce);
        }
        else
        {
            movementLogic.Run(0);
        }
    }
}
