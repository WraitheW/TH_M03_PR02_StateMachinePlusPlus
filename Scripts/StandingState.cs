using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StandingState : PlayerState
{

    public void Enter(Player player)
    {
        player.mCurrentState = new StandingState();
        Debug.Log("Enter Standing State");
    }

    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            JumpingState jumpingState = new JumpingState();
            jumpingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            DuckingState duckingState = new DuckingState();
            duckingState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            SpinningState spinningState = new SpinningState();
            spinningState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.I))
        {
            InvisibleState invisibleState = new InvisibleState();
            invisibleState.Enter(player);
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            RudeState rudeState = new RudeState();
            rudeState.Enter(player);
        }
    }
}
