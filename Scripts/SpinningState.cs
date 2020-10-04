using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningState : PlayerState
{
    public void Enter(Player player)
    {
        player.mCurrentState = new SpinningState();
        Debug.Log("Enter Spinning State");
    }

    public void Execute(Player player)
    {
        float RotationSpeed = 90f;
        player.transform.Rotate(Vector3.up * (RotationSpeed * Time.deltaTime));

        if (Input.GetKeyUp(KeyCode.S))
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }

    }
}
