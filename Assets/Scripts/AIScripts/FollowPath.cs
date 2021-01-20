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
    public Vector3[] waypoints;

    int index;

    public Grid grid;

<<<<<<< Updated upstream
    private void Awake()
    {
        grid = FindObjectOfType<Grid>();
    }

    public override Steering GetSteering(MovementInfoAI enemy, MovementInfoAI target)
    {
        Steering steering = new Steering();

        waypoints = new Vector3[grid.path.Count];

        for (int i = 0; i < grid.path.Count; i++)
        {
            waypoints[i] = grid.path[i].worldPosition;
            waypoints[i].z = -0.06f;
        }

        Debug.Log(waypoints.Length);

        for (index = 0; index < waypoints.Length; index++)
        {
            target.position = waypoints[index];
            Vector3 direction = target.position - enemy.position;

            float distance = Vector3.Distance(target.position, enemy.position);

            if(distance > 0.1f)
            {

                Vector3 targetVelocity = direction.normalized;

                steering.linear = direction.normalized * maxAccel;
                //return steering;
            }
            else return steering;
        }

        enemy.position.z = -0.06f;
=======
    //public override Steering GetSteering(MovementInfoAI enemy, MovementInfoAI target)
    //{
    //    Steering steering = new Steering();

    //    Vector3 direction = grid.path[0].worldPosition - enemy.position;

    //    direction.z = -0.06f;

    //    float distance = direction.magnitude;

    //    float targetSpeed;
    //    if (distance > slowRadius) targetSpeed = maxSpeed;
    //    else targetSpeed = maxSpeed * distance / slowRadius;

    //    Vector3 targetVelocity = direction.normalized;

    //    targetVelocity *= targetSpeed;
    //    steering.linear = targetVelocity - enemy.velocity;
    //    steering.linear /= timeToTarget;

    //    enemy.position.z = -0.06f;
>>>>>>> Stashed changes

    //    steering.linear = Vector3.ClampMagnitude(steering.linear, maxAccel);

    //    return steering;
    //}
}