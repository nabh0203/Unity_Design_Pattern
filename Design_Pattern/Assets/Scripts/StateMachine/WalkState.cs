using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkState : IState
{
    private PlayerController player;
    public WalkState(PlayerController player)
    {
        this.player = player;
    }
    public void Enter()
    {
        // 상태에 처음 진입할 때 실행되는 코드
    }
    public void Update()
    {
        // 조건이 다른 상태로 전환하기 위해
        // 존재하는지 여부를 감지하기 위한 로직 추가
    }
    public void Exit()
    {
        // 상태에서 벗어날 때 실행되는 코드
    }
}
