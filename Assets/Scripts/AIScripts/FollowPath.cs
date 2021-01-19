using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "Behaviour/FollowPath")]
public class FollowPath : SeekAI
{
    float slowRadius = 1.5f;
    float maxSpeed = 5f;
    float timeToTarget = 5f;
    float maxAccel = 2f;

    int targetIndex = 0;
    
    public Grid grid;

    public override Steering GetSteering(MovementInfoAI enemy, MovementInfoAI target)
    {
        Steering steering = new Steering();

        Vector3 direction = grid.path[0].worldPosition - enemy.position;

        direction.z = -0.06f;

        float distance = direction.magnitude;

        if (distance <= 0.001f && enemy.position == grid.path[grid.path.Count -1])
        {
            return steering;
        }
        float targetSpeed;
        if (distance > slowRadius) targetSpeed = maxSpeed;
        else targetSpeed = maxSpeed * distance / slowRadius;

        Vector3 targetVelocity = direction.normalized;

        targetVelocity *= targetSpeed;
        steering.linear = targetVelocity - enemy.velocity;
        steering.linear /= timeToTarget;

        steering.linear = Vector3.ClampMagnitude(steering.linear, maxAccel);

        return steering;
    }
}