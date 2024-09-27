using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerTest : MonoBehaviour
{
    private IPlayerState currentState;

    void Start()
    {
        // 초기 상태 설정
        currentState = new TestState(this);
    }

    void Update()
    {
        currentState.HandleInput();
    }

    public void SetState(IPlayerState newState)
    {
        currentState = newState;
    }
}

public interface IPlayerState
{
    void HandleInput();
}

public class TestState : IPlayerState
{
    private PlayerControllerTest playerController;

    public TestState(PlayerControllerTest player)
    {
        playerController = player;
    }

    public void HandleInput()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            Debug.Log("위쪽 키가 눌렸습니다.");
            playerController.SetState(new MoveUpState(playerController));
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            Debug.Log("아래쪽 키가 눌렸습니다.");
            playerController.SetState(new MoveDownState(playerController));
        }
        else if (Input.GetKeyDown(KeyCode.A))
        {
            Debug.Log("왼쪽 키가 눌렸습니다.");
            playerController.SetState(new MoveLeftState(playerController));
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            Debug.Log("오른쪽 키가 눌렸습니다.");
            playerController.SetState(new MoveRightState(playerController));
        }
    }
}

public class MoveUpState : IPlayerState
{
    private PlayerControllerTest playerController;

    public MoveUpState(PlayerControllerTest player)
    {
        playerController = player;
    }

    public void HandleInput()
    {
        Debug.Log("플레이어가 위로 이동 중...");
        if (Input.GetKeyUp(KeyCode.W))
        {
            playerController.SetState(new TestState(playerController));
        }
    }
}

public class MoveDownState : IPlayerState
{
    private PlayerControllerTest playerController;

    public MoveDownState(PlayerControllerTest player)
    {
        playerController = player;
    }

    public void HandleInput()
    {
        Debug.Log("플레이어가 아래로 이동 중...");
        if (Input.GetKeyUp(KeyCode.S))
        {
            playerController.SetState(new TestState(playerController));
        }
    }
}

public class MoveLeftState : IPlayerState
{
    private PlayerControllerTest playerController;

    public MoveLeftState(PlayerControllerTest player)
    {
        playerController = player;
    }

    public void HandleInput()
    {
        Debug.Log("플레이어가 왼쪽으로 이동 중...");
        if (Input.GetKeyUp(KeyCode.A))
        {
            playerController.SetState(new TestState(playerController));
        }
    }
}

public class MoveRightState : IPlayerState
{
    private PlayerControllerTest playerController;

    public MoveRightState(PlayerControllerTest player)
    {
        playerController = player;
    }

    public void HandleInput()
    {
        Debug.Log("플레이어가 오른쪽으로 이동 중...");
        if (Input.GetKeyUp(KeyCode.D))
        {
            playerController.SetState(new TestState(playerController));
        }
    }
}
