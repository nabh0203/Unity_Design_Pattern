using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.Serialization;
using UnityEngine;

public enum PlayerState
{
    First,
    Second,
    Third
}
public class Player : MonoBehaviour
{
    PlayerState playerState;

    void Update()
    {
        PlayerController();
        switch (playerState)
        {
            case PlayerState.First:
                break;
            case PlayerState.Second:
                break;
            case PlayerState.Third:
                break;
        }   
    }

    void PlayerController()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            print("left");
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            print("right");
        }
    }
}
[Serializable]
public class PlayerStage : MonoBehaviour
{
    public IStage currentStage { get; private set; }
    [SerializeField] FirstStage firstStage;
    [SerializeField] SecondStage secondStage;
    [SerializeField] ThirdStage thirdStage;

    public void StageStart(IStage startingStage)
    {
        currentStage = startingStage;
        startingStage.Enter();
    }
    public void Update()
    {
        if (currentStage != null)
        {
            currentStage.Update();
        }
    }
    public void StageStop(IStage nextStage)
    {
        currentStage = nextStage;
        nextStage.Exit();
    }
    public PlayerStage(PlayerStage stage)
    {
        this.firstStage = new FirstStage(stage);
        this.secondStage = new SecondStage(stage);
        this.thirdStage = new ThirdStage(stage);
    }
}
