using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBevaviour : ScriptableObject
{ 
	public abstract Steering GetSteering(MovementInfoAI EmenyAI, MovementInfoAI target);
}
