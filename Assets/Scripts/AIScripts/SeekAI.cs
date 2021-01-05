using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Comportamentos/SeekAI")]

public class SeekAI : SteeringBevaviour
{
	[SerializeField]
	float Aceral = 1f;

    public override Steering GetSteering(MovementeInfoAI EmenyAI, MovementeInfoAI target)
    {
        Vector3 direcao = target.position - EmenyAI.position;

        Steering streering = new Steering();
        streering.linear = direcao.normalized * Aceral;

        return streering;
    }
}
