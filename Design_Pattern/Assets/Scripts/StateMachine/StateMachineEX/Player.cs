using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public IMotion currentMotion { get; private set; }
    [SerializeField] RunMotion runMotion;
    [SerializeField] StopMotion stopMotion;
    [SerializeField] AttackMotion attackMotion;

    public void MotionUp (IMotion startingMotion)
    {
        currentMotion = startingMotion;

    }
}
