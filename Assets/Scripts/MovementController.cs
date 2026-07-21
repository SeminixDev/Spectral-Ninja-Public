using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour
{

    float originalXDirection = 1;

    Rigidbody2D rb;

    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();

        CheckOriginalXScale();
    }

    private void CheckOriginalXScale()
    {
        originalXDirection = Mathf.Sign(transform.localScale.x);
    }

    public void Jump(float force)
    {
        rb.velocity = new Vector2(rb.velocity.x, force);
    }

    public void Run(float speed)
    {
        rb.velocity = new Vector2(speed, rb.velocity.y);

        if (speed != 0)
        {
            flipSprite(Mathf.Sign(speed));
        }
    }

    private void flipSprite(float direction)
    {
        if((Mathf.Sign(transform.localScale.x) * originalXDirection) != direction)
        {
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
    }

}
