using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvisibleState : PlayerState
{

    public void Enter(Player player)
    {
        player.mCurrentState = new InvisibleState();
        player.transform.position = new Vector3(1000f, 1f, 1000f);
        Debug.Log("Enter Invisible State");
    }

    public void Execute(Player player)
    {

        if (Input.GetKeyUp(KeyCode.I))
        {
            player.transform.position = new Vector3(-0.0010441f, 0.05f, -5.82f);
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
