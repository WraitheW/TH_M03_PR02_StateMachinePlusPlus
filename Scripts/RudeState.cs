using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RudeState : PlayerState
{
    public GameObject tongue;
    public void Enter(Player player)
    {
        player.mCurrentState = new RudeState();
        tongue = player.gameObject.transform.GetChild(1).gameObject;
        tongue.gameObject.SetActive(true);
        Debug.Log("Enter Rude State");
    }

    public void Execute(Player player)
    {

        if (Input.GetKeyUp(KeyCode.R))
        {
            tongue = player.gameObject.transform.GetChild(1).gameObject;
            tongue.gameObject.SetActive(false);
            StandingState standingState = new StandingState();
            standingState.Enter(player);
        }
    }
}
