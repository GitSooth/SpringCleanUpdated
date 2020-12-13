using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Comportamentos/SeekAI")]
public class SeekAI : SteeringBevaviour
{
	[SerializeField]
	float Aceral = 1f;

    public override Streering GetStreering(MovementeInfoAI EmenyAI, MovementeInfoAI target)
    {
        Vector3 direcao = target.position - EmenyAI.position;

        Streering streering = new Streering();
        streering.linear = direcao.normalized * Aceral;

        return streering;
    }
}
