using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Comportamentos/SeekAI")]

public class SeekAI : SteeringBevaviour
{
	[SerializeField]
	float accel = 1f;

    public override Steering GetSteering(MovementInfoAI EmenyAI, MovementInfoAI target)
    {
        Vector3 direcao = target.position - EmenyAI.position;

        Steering streering = new Steering();
        streering.linear = direcao.normalized * accel;

        return streering;
    }

    
}
