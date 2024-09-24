using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadVehicle : IMovable, ITurnable
{
	public float speed = 100f;
	public float turnSpeed = 5f;
	public virtual void GoForward()
	{
        /*肺流 备泅*/
    }
    public virtual void Reverse()
	{
        /*肺流 备泅*/
	}
	public virtual void TurnLeft()
	{
        /*肺流 备泅*/
	}
	public virtual void TurnRight()
	{
        /*肺流 备泅*/
	}
}