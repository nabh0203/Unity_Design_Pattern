public class IdleState : IState
{
    private PlayerController player;
    public IdleState(PlayerController player)
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
