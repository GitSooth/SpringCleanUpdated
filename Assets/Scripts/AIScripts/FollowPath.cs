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

    public Grid grid;

    private void Start()
    {
        // grid = FindObjectOfType<Grid>();
        grid = GameObject.FindGameObjectWithTag("AStar").GetComponent<Grid>();
    }

    public override Steering GetSteering(MovementInfoAI enemy, MovementInfoAI target)
    {
        bool follow = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Program>().following;
        if (!grid) grid = GameObject.FindGameObjectWithTag("AStar").GetComponent<Grid>();

        if (follow == true)
        {
            Steering steering = new Steering();
            if (grid.path.Count > 1)
            {
                target.position = grid.path[1].worldPosition;
            }
        }
        else
        {
            target.position = enemy.position;
        }
        return base.GetSteering(enemy, target);
    }
}