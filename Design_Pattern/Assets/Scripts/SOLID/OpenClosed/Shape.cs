using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Shape
{
    public abstract float CalculateArea();
    /*
        위 처럼 상속할 수 있는 추상 메서드를 생성한다.
    
        이렇게 추상 메서드를 생성하여 Rectangle, Circle 에 상속하게 되면 각자의 영역을 계산하게 된다. 
    */
}