using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*디자인 패턴 공부  : 리스코프 치환 원칙*/
public class Vehicle : MonoBehaviour 
{
    /* public float speed = 100;
     public Vector3 direction;
     public void GoForward()
     {

     }
     public void Reverse()
     { 

     }
     public void TurnRight()
     {

     }
     public void TurnLeft()
     {

     }*/

    /*
        LSP(리스코프 치환 원칙)는 파생된 클래스가 기본 클래스로 대체될 수 있어야 한다고 명시되어 있다. 
        객체 지향 프로그래밍에서 상속을 사용하면 서브 클래스를 통해 기능을 추가할 수 있으나 주의하지 않으면 불필요한 복잡성을 더할 수 있다. 
        
        LSP(리스코프 치환 원칙)는 상속을 통해 서브 클래스를 강력하고 유연하게 만들수 있다.
        위처럼 Vehicle 클래스를 만들어 해당 클래스는 애플리케이션에서 사용할 차량이라는 하위 클래스의 기본 클래스로 만들어준다. 
        자동차나 트럭을 사용하려는 경우를 예로 들 수 있으며 기본 클래스(Vehicle)를 사용할 수 있는 모든 위치에서 애플리케이션에 
        오류를 발생시키지 않고 Car 또는 Truck과 같은 서브 클래스를 사용할 수 있게 한다.
    */

    /* public class Navigator
     {
         public void Move(Vehicle vehicle)
         {
             vehicle.GoForward();
             vehicle.TurnLeft();
             vehicle.GoForward();
             vehicle.TurnRight();
             vehicle.GoForward();
         }
     }*/

    /*
        그리고 위의 코드처럼 Car Truck 두 개의 서브 클래스에서 공통적으로 사용되는 Navigator라는 클래스를 생성하여 관리할수 있게 된다.
        그러나 만약 Train 이라는 서브 클래스가 추가가 된다면 위 Navigator의  Move 메서드는 일반적인 기차가 철로를 좌 우로 이탈할 수 없는것처럼
        TurnLeft(); , TurnRight(); 를 전달하지 못하게 된다.
        이처럼 특정 유형을 하위 유형과 교체하지 못한다면 리스코프 치환 원칙을 위반하게 된다.
    
        Train 이라는 서브 클래스는Vehicle 클래스 하위 유형이므로 Vehicle 클래스가 허용되는 모든 위치내에서 사용이 가능해야 한다.
        그러지 않으면 코드가 예측할 수 없는 방식으로 작동할 수 있게된다.
     */

    /*
        그리고 리스코프 치환 원칙을 더 철저하게 준수하기 위한 몇 가지 팁이 존재한다.

        — 서브 클래스를 설정할 때 기능을 제거하면 리스코프 치환을 위반하게 될 가능성이 크다.
          NotImplementedException은 이 원칙을 위반했다는 의미이며, 메서드를 비워 두는 경우도 마찬가지이다.
          서브 클래스가 기본 클래스처럼 동작하지 않는다면 오류나 예외가 명시적으로 보이지 않더라도 LSP를 준수하지 않는 것이다.

        — 추상화를 단순하게 유지한다.
          기본 클래스에 들어가는 로직이 많을수록 LSP를 위반할 확률도 커진다.
          기본 클래스는 파생 서브 클래스의 일반적인 기능만 표현해야 한다.

        — 서브 클래스는 기본 클래스와 동일한 공용 멤버를 가져야 한다.
          또한 그러한 공용 멤버는 호출 시 동일한 서명을 갖고 동일한 동작을 취해야 한다.

        — 클래스 계층 구조를 수립할 때 클래스 API를 고려한다.
          대상을 모두 차량으로 간주하더라도 Car와 Train은 각각 서로 다른 부모 클래스로부터 상속하는 편이 더 나을 수 있다.
          실질적으로 분류가 항상 클래스 계층 구조와 일치하지는 않는다.

        — 상속보다는 합성을 우선시한다.
          상속을 통해 기능의 전달을 시도하는 대신, 특정한 동작을 캡슐화할 있도록 인터페이스 또는 별도의 클래스를 만든 뒤
          믹스 앤 매치를 통해 다양한 기능의 합성물을 생성한다. 
    */
    /*
        그리하여 Navigator Calss 의 로직들을 인터페이스화 하여 스크립트로 분산 시킨 뒤 Car 전용 스크립트와 Train 전용 스크립트를 만들어 관리하면 된다.
        리스코프 치환 원칙에 따라 상속 사용 방법에 제한을 두어 코드 베이스를 확장 가능하고 유연하게 유지해야 한다.
    */
}
