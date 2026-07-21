using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Animator))]
public class AnimationManager : MonoBehaviour
{

    public const string JUMP = "Jump";
    public const string DEATH = "Death";
    public const string RUNNING = "isRunning";
    public const string FALLING = "isFalling";
    public const string GROUNDED = "isGrounded";

    Animator animator;

    void Awake()
    {
        animator = GetComponent<Animator>();
    }

    // Set the parameter while checking if it exists and what type of parameter it is
    public void SetParameter(string paramName, bool paramValue = true)
    {
        foreach (AnimatorControllerParameter param in animator.parameters)
        {
            if (param.name == paramName)
            {
                if (param.type == AnimatorControllerParameterType.Trigger)
                {
                    animator.SetTrigger(paramName);
                }
                else if (param.type == AnimatorControllerParameterType.Bool)
                {
                    animator.SetBool(paramName, paramValue);
                }
            }
        }
    }


}
