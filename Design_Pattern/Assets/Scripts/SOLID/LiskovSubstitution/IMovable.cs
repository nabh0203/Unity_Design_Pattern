using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*디자인 패턴 공부  : 리스코프 치환 원칙*/
public interface IMovable
{
    public void GoForward();
    public void Reverse();
}