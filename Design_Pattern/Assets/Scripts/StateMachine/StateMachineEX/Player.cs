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

