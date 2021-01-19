using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    MovementInfoAI info;
    [SerializeField]
    float linearDrag = 0.95f;
    [SerializeField]
    float angularDrag = 0.95f;
    [SerializeField]
    float maxVelocity = 20f;
    [SerializeField]
    float rotationVelocity = Mathf.PI / 8f;
    [SerializeField]
    float walkVelocity = 8f;

    public MovementInfoAI GetInfo => info;

    void Awake()
    {
        info.position = transform.position;
        Vector3 forward = transform.forward;
        info.orientation = Mathf.Atan2(forward.x, forward.z);
    }

    // Update is called once per frame
    void Update()
    {
        info.position = transform.position;

        Vector3 forward = transform.forward;
        info.orientation = Mathf.Atan2(forward.x, forward.z);

    }
}
