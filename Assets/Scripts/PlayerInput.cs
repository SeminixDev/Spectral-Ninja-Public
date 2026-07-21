using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{

    MovementLogic playerMovement;

    void Awake()
    {
        playerMovement = GetComponent<MovementLogic>();
    }

    void Update()
    {
        CheckForUserInput();
    }

    void CheckForUserInput()
    {
        // Jump
        if (Input.GetKeyDown(KeyCode.W) || Input.GetKeyDown(KeyCode.Space))
        {
            playerMovement.WantsToJump = true;
        }

        // Move Right
        if (Input.GetKey(KeyCode.D))
        {
            playerMovement.WantsToMoveRight = true;
        }
        else
        {
            playerMovement.WantsToMoveRight = false;
        }

        // Move Left
        if (Input.GetKey(KeyCode.A))
        {
            playerMovement.WantsToMoveLeft = true;
        }
        else
        {
            playerMovement.WantsToMoveLeft = false;
        }
    }

}
