using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*디자인 패턴 공부 : 인터페이스 분리 원칙*/
public interface IUnitStats
{
    public float Health { get; set; }
    public int Defense { get; set; }
    public void Die();
    public void TakeDamage();
    public void RestoreHealth();
    public float MoveSpeed { get; set; }
    public float Acceleration { get; set; }
    public void GoForward();
    public void Reverse();
    public void TurnLeft();
    public void TurnRight();
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
}
/*
    ISP(인터페이스 분리 원칙)는 어떠한 클라이언트도 자신이 사용하지 않는 메서드에 강제로 종속될 수 없다고 명시 되어 있다.
    정리하면 인터페이스의 규모가 커지지 않게 해야 하며 클래스와 메서드의 길이를 짧게 유지하는 단일 책임 원칙과 같은 맥락으로 이해하면 된다.
    그러면 유연성을 최대로 향상하며, 집중도가 높고 컴팩트한 인터페이스를 유지할 수 있다.

    만약 위에 인터페이스에서 부술수 있는 통 이나 파괴 가능한 프랍을 추가 하게 된다면 상당수의 코드가 들어가게 된다 이런 상황에서 사용되는것이
    인터페이스 분리 원칙이며 이러한 원칙을 통해 하나에 여러개의 메서드를 넣는것이 아닌 여러개의 작은 인터페이스로 분리하여 필요한 상황에
    필요한 요소만 사용할수 있다.
*/

/*public interface IMovable
{
    public float MoveSpeed { get; set; }
    public float Acceleration { get; set; }
    public void GoForward();
    public void Reverse();
    public void TurnLeft();
    public void TurnRight();
}
public interface IDamageable
{
    public float Health { get; set; }
    public int Defense { get; set; }
    public void Die();
    public void TakeDamage();
    public void RestoreHealth();
}
public interface IUnitStats
{
    public int Strength { get; set; }
    public int Dexterity { get; set; }
    public int Endurance { get; set; }
}
public interface IExplodable 
{
 public float Mass { get; set; }
 public float ExplosiveForce { get; set; }
 public float FuseDelay { get; set; }
 public void Explode();
}
    위는 인터페이스 분리 원칙을 지켜 분할된 인터페이스의 모습이다.
    이런식으로 작은 요소들로 나누어 
    
public class ExplodingBarrel : MonoBehaviour, IDamageable, IExplodable
{
    //로직 구현
}
public class EnemyUnit : MonoBehaviour, IDamageable, IMovable, 
IUnitStats
{
    //로직 구현
}

    이처럼 인터페이스 분리 원칙은 리스코프 치환의 예시와 유사하게 여기에서도 상속보다 합성을 우선시한다.
    인터페이스 분리 원칙은 시스템을 분리하고 간편하게 수정 및 재배포하는 데 도움이 된다.
 
 */


