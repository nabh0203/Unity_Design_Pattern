using System;
using System.Collections;
using System.Collections.Generic;
using Unity.IO.LowLevel.Unsafe;
using UnityEngine;

[Serializable]
public class StateMachine : MonoBehaviour
{
    public IState currentState {  get; private set; }
    public WalkState walkState;
    public JumpState jumpState;
    public IdleState idleState;
    public void Initialize(IState startingState)
    {
        currentState = startingState;
        startingState.Enter();
    }
    public void TransitionTo(IState nextState)
    {
        currentState.Exit();
        currentState = nextState;
        nextState.Enter();
    }
    public void Update()
    {
        if (currentState != null)
        {
            currentState.Update();
        }
    }
    public StateMachine(PlayerController player)
    {
        this.walkState = new WalkState(player);
        this.jumpState = new JumpState(player);
        this.idleState = new IdleState(player);
    }
}
public enum PlayerControllerState
{
    Idle,
    Walk,
    Jump
}
public class PlayerController : MonoBehaviour
{
    private StateMachine stateMachine;

    private void Awake()
    {
        stateMachine = new StateMachine(this);
        stateMachine.Initialize(stateMachine.idleState); // �ʱ� ���� ����
    }

    private void Update()
    {
        GetInput();
        stateMachine.Update(); // ���� ����� ������Ʈ ȣ��
    }

    private void GetInput()
    {
        // �Է� ó�� ����

        // ���� ��ȯ ����
        if (Input.GetKeyDown(KeyCode.W))
        {
            stateMachine.TransitionTo(stateMachine.walkState);
        }
        else if (Input.GetKeyDown(KeyCode.Space))
        {
            stateMachine.TransitionTo(stateMachine.jumpState);
        }
        else if (Input.GetKeyDown(KeyCode.None))
        {
            stateMachine.TransitionTo(stateMachine.idleState);
        }
    }
}

