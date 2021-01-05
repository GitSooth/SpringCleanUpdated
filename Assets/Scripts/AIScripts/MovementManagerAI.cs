using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementManagerAI : MonoBehaviour
{
    [SerializeField]
    MovementeInfoAI info;
    [SerializeField]
    SteeringBevaviour steeringBehaviour;
    [SerializeField, Range(0, 1)]
    float linearDrag = 0.95f, angularDrag = 0.95f;
    [SerializeField, Tooltip("NPC max velocity")]
    float maxVelocity = 2f;

    MovementeInfoAI target;
    public MovementeInfoAI GetInfo => info;
    // Start is called before the first frame update
    void Awake()
    {
        info.position = transform.position;
        Vector3 forward = transform.forward;
        info.orientation = Mathf.Atan2(forward.x, forward.z);

        steeringBehaviour = Instantiate(steeringBehaviour);
        //steeringBehaviour.Init();
    }

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMovement>().GetInfo;
    }

    // Update is called once per frame
    void Update()
    {
        // Update our position and our orientation 
        info.position += info.velocity * Time.deltaTime;
        info.orientation += info.rotation * Time.deltaTime;

        // Apply drag
        info.velocity *= linearDrag;
        info.rotation *= angularDrag;

        // Get the movement steering data, and update our velocities
        Steering steering = steeringBehaviour.GetSteering(info, target);
        info.velocity += steering.linear;
        info.rotation += steering.angular;

        // Do not exceed our max velocity
        info.velocity = Vector3.ClampMagnitude(info.velocity, maxVelocity);

        // Do not forget to transform radians into degrees
        info.orientation = NormAngle(info.orientation);
        transform.rotation = Quaternion.identity;
        transform.Rotate(transform.up, info.orientation * Mathf.Rad2Deg);
        transform.position = info.position;
    }

    public static float NormAngle(float angle)
    {
        while (angle < -Mathf.PI) angle += Mathf.PI * 2f;
        while (angle > Mathf.PI) angle -= Mathf.PI * 2f;
        return angle;
    }
}