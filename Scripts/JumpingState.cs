using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class JumpingState : PlayerState
{
    float airTime;

    public void Enter(Player player)
    {
        player.mCurrentState = new JumpingState();
        player.GetComponent<Rigidbody>().velocity = new Vector3(0, 10f, 0);
        Debug.Log("Enter Jumping State");
    }
    public void Execute(Player player)
    {
        if (Input.GetKeyDown(KeyCode.LeftControl))
        {
            DivingState divingState = new DivingState();
            divingState.Enter(player);
        }

        airTime += Time.time;

        if (Physics.Raycast(player.transform.position, Vector3.down, 1f) && 2 * airTime > Time.time)
        {
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
