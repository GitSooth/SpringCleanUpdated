using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class MovementInfoAI
{
	// Current position
	public Vector3 position;

	// Current orientation
	public float orientation;

	// Movement direction and speed
	public Vector3 velocity;

	public float rotation;
}
