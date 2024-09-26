using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstStage : StageState, IStage
{
    PlayerStage player;
    public FirstStage(PlayerStage player)
    {
        this.player = player;
    }
    public  void Enter()
    {
        score = 0;
    }
    public void Update()
    {

    }
    public void Exit()
    {

    }
}
