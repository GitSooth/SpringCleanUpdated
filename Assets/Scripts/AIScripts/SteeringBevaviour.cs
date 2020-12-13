using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class SteeringBevaviour : ScriptableObject
{ 
	public abstract Streering GetStreering(MovementeInfoAI EmenyAI, MovementeInfoAI target);
}
