using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DivingState : PlayerState
{
    public float airTime;

    public void Enter(Player player)
    {
        player.mCurrentState = new DivingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, -20f, 0);
        Debug.Log("Enter Diving State");
    }
    public void Execute(Player player)
    {
        if (Physics.Raycast(player.transform.position, Vector3.down, 1f))
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
