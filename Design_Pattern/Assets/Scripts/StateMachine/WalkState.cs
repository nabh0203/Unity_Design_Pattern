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
        // ���¿� ó�� ������ �� ����Ǵ� �ڵ�
    }
    public void Update()
    {
        // ������ �ٸ� ���·� ��ȯ�ϱ� ����
        // �����ϴ��� ���θ� �����ϱ� ���� ���� �߰�
    }
    public void Exit()
    {
        // ���¿��� ��� �� ����Ǵ� �ڵ�
    }
}
