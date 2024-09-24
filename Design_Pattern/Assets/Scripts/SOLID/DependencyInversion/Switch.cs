using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*디자인 패턴 공부 : 종속성 역전 원칙*/
/*public class Switch : MonoBehaviour
{
    public Door door;
    public bool isActivated;
    public void Toggle()
    {
        if (isActivated)
        {
            isActivated = false;
            door.Close();
        }
        else
        {
            isActivated = true;
            door.Open();
        }
    }
}*/
public class Switch : MonoBehaviour
{
    public ISwitchable client;
    public void Toggle()
    {
        if (client.IsActive)
        {
            client.Deactivate();
        }
        else
        {
            client.Activate();
        }
    }
}

/*
    DIP(종속성 역전 원칙)는 상위 수준의 모듈이 하위 수준의 모듈에서 어떤 것도 직접 가져오면 안 된다고 명시 되어 있다.
    다른 클래스와 관계가 있는 클래스는 종속 또는 결합 관계가 있다고 부르나 이러한건 소프트웨어 디자인에서 각 종속성은 약간의 위험성을 내포한다.
    한 클래스가 다른 클래스의 작동 방식에 대해 너무 많이 아는 경우, 첫 번째 클래스를 수정하면 두 번째 클래스에 피해를 줄 수 있으며 
    그 반대의 경우도 마찬가지입니다. 결합도가 높으면 깔끔하지 않은 코드로 간주 되며 애플리케이션의 한 부분에서 오류 발생 시 다른 부분으로 
    눈덩이처럼 확대될 수 있다.

    그리하여 클래스 간 종속성은 가능 한 최소화 하는것이 이상적이며 각 클래스의 내부 요소가 한결같이 작동 되어야 하고 외부 연결에 의존해선 안된다.
    내부 로직 및 프라이빗 로직으로 작동되는 객체는 응집도가 높다고 할 수 있다.
    그 중 최고의 시나리오는 결합도는 낮추면서 응집도가 높은것이다. 그리고 수정이 용이해야 하며 수정하기 어렵다면 어떻게 구조화 되어 있는지를 파악해야 한다.

    종속성 역전 원칙의 예시로  문을 트리거해 여는 로직을 구현할때
    Switch 스크립트와 Door 스크립트 두개를 만들어 상위문을 Switch 스크립트로 지정하여 Switch 문 안의 토글 로직이 반응 하면 디버그를 호출 하는 예시를
    만든다.
    
    만약 로직을 추가하려면 Swhitch 스크립트에 메서드를 추가할 수 있겠지만 그렇게 되면 개방-폐쇄 원칙을 위반하게 됨으로 기능을 추가하기 위해선
    원본 코드를 수정해야만 한다.

    이러면 추상화를 통해 해결하는 방법이 있다. 먼저 두 클래스 사이에 ISwitchable 라는 인터페이스를 삽입한다.
    
     ISwitchable 는 액티브 상태인지 확인하는 프로퍼티와 Activate 및 Deactivate라는 메서드 2개가 들어있다.
    이러한 인터페이스를 만들어 여러곳에서 재사용이 가능하게 해주며 프로젝트를 간편하게 축소 및 확장이 가능하게 한다.


    
*/