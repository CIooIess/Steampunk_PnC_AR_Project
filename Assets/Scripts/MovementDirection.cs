using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementDirection : MonoBehaviour
{
	public enum movementDirection { Away, Towards, Left, Right, Up, Down, Into, Outof };

	public movementDirection ReverseDirection(movementDirection dir)
	{
		if (dir == movementDirection.Away)
			dir = movementDirection.Towards;
		else if (dir == movementDirection.Towards)
			dir = movementDirection.Away;

		else if (dir == movementDirection.Left)
			dir = movementDirection.Right;
		else if (dir == movementDirection.Right)
			dir = movementDirection.Left;

		else if (dir == movementDirection.Up)
			dir = movementDirection.Down;
		else if (dir == movementDirection.Down)
			dir = movementDirection.Up;

		else if (dir == movementDirection.Into)
			dir = movementDirection.Outof;
		else if (dir == movementDirection.Outof)
			dir = movementDirection.Into;

		return dir;
	}
}
