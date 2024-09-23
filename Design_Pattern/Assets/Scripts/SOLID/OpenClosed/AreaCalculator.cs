using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*������ ���� ����  : ���� - ����� ��Ģ*/
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
    SOLID �����ο��� OCP(����-��� ��Ģ)�� Ŭ������ Ȯ�忡�� �������̵� �������� ������̾�� �Ѵٰ� ��� �ȴ�.
    ���� �ڵ带 �������� �ʰ� ���ο� ������ ������ �� �ֵ��� Ŭ������ ����ȭ �� �� �־�� �Ѵ�.

    ��ǥ���� ���÷� �� �ڵ�ó�� Shape�� ������ ����ϴ� �ڵ���̴�
    ���簢���� ���� ���̸� ���ϴ� Ŭ������ ���� �� ������ ������ ����ϱ� ���ؼ� Rectangle Ŭ������ Width �� height �� �ʿ��ϰ�
    Circle Ŭ������ radius�� ���� ������ �ʿ��ϴ�.
    
    �׷��� ����ؼ� ���ϴ� ���� ������ ����ϱ� ���ؼ� Ŭ������ �߰��ϰ� �Ǹ� �͹��� ���� �ڵ差�� �����ǰ� ������ �Ұ����� ������ �ִ�.
    ����,Shape��� �⺻ Ŭ������ ����� �������� ó���� �޼��带 �ϳ� ���� ���� ������ �� ������ ������ ó���ϵ��� ���� �ȿ� 
    ���� ���� if ���� �־�� �ϸ� �׷��� �����ϸ� Ȯ�强�� �������� �ȴ�.

    �׸��Ͽ� ���� �ڵ带 �������� �����鼭 ���ο� Shape�� ����� �� �ְ� Ȯ�强�� ������ �Ѵ�.
    ������ �ڵ�� OCP(����-��� ��Ģ) �� ������ �ڵ��̴�.
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
    �׸��Ͽ� �� �ڵ�ó�� OCP(����-��� ��Ģ) �� ��Ű�� ����� �ް� �Ǹ� �� ������ ����� �� �ְ� �ȴ�.
    ����, �ʱ� Ŭ������ OpenClosed�� �Ʒ� ó�� �ܼ�ȭ�� ����������.
    public float GetArea(Shape shape)
    {
        return shape.CalculateArea();
    }

    ���� ���ϴ� Shape�� ������ Ȯ���ų�� �ְ� �ȴ�. 
    ���ο� �ٰ����� Ŭ������ �����ѵ� Shape�� ��� ���� �߻�޼����� CalculateArea()�ȿ� �˸´� ���� �ְ� �Ǹ� 
    If, Swhich���� ���� �ʿ���� ����� ����������.
 */
