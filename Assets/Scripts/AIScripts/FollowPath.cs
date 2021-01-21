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

    private void Start()
    {
        // grid = FindObjectOfType<Grid>();
        grid = GameObject.Find("AStar").GetComponent<Grid>();
    }

    public override Steering GetSteering(MovementInfoAI enemy, MovementInfoAI target)
    {
        if (!grid) grid = GameObject.Find("AStar").GetComponent<Grid>();

        Steering steering = new Steering();
        if (grid.path.Count > 1)
        {
            target.position = grid.path[1].worldPosition;
        }
        return base.GetSteering(enemy, target);
    }
}