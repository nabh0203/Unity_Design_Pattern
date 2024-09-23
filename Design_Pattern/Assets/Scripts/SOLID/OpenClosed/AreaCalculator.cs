using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*디자인 패턴 공부  : 개방 - 폐쇄의 원칙*/
public class AreaCalculator : MonoBehaviour
{
    /*
    public float GetRectangleArea(Rectangle rectangle)
    {
        return rectangle.width * rectangle.height;
    }
    public float GetCircleArea(Circle circle)
    {
        return circle.radius * circle.radius * Mathf.PI;
    }*/

    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }
}
/*public class Rectangle
{
    public float width;
    public float height;
}
public class Circle
{
    public float radius;
}*/
/* 
    SOLID 디자인에서 OCP(개방-폐쇄 원칙)는 클래스가 확장에는 개방적이되 수정에는 폐쇄적이어야 한다고 명시 된다.
    원본 코드를 수정하지 않고도 새로운 동작을 생성할 수 있도록 클래스를 구조화 할 수 있어야 한다.

    대표적인 예시로 위 코드처럼 Shape의 영역을 계산하는 코드들이다
    직사각형과 원의 넓이를 구하는 클래스를 만들 수 있으며 영역을 계산하기 위해서 Rectangle 클래스는 Width 와 height 가 필요하고
    Circle 클래스는 radius와 파이 값만이 필요하다.
    
    그러나 계속해서 원하는 도형 영역을 계산하기 위해서 클래스를 추가하게 되면 터무니 없는 코드량이 증가되고 수정이 불가피해 질수도 있다.
    또한,Shape라는 기본 클래스를 만들고 셰이프를 처리할 메서드를 하나 만들 수도 있지만 각 셰이프 형식을 처리하도록 로직 안에 
    여러 개의 if 문이 있어야 하며 그렇게 구현하면 확장성이 떨어지게 된다.

    그리하여 원문 코드를 수정하지 않으면서 새로운 Shape를 사용할 수 있게 확장성을 넓혀야 한다.
    현재의 코드는 OCP(개방-폐쇄 원칙) 를 위반한 코드이다.
*/
public class Rectangle : Shape
{
    public float width;
    public float height;

    public override float CalculateArea()
    {
        return width * height;
    }
}
public class Circle : Shape
{
    public float radius;

    public override float CalculateArea()
    {
        return radius * radius * Mathf.PI;
    }
}
/*
    그리하여 위 코드처럼 OCP(개방-폐쇄 원칙) 을 지키며 상속을 받게 되면 각 영역을 계산할 수 있게 된다.
    또한, 초기 클래스인 OpenClosed도 아래 처럼 단순화가 가능해진다.
    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }

    이제 원하는 Shape의 영역을 확장시킬수 있게 된다. 
    새로운 다각형의 클래스를 생성한뒤 Shape를 상속 시켜 추상메서드인 CalculateArea()안에 알맞는 식을 넣게 되면 
    If, Swhich문을 넣을 필요없이 계산이 가능해진다.
 */
