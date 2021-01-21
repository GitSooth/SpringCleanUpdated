using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Program : MonoBehaviour
{
    public Transform target;
    float detectionRadius = 5f;
    float distance;
    public bool following = false;
    DTCondiccao inRange;

     void Start()
    {
        /*
            *    distance > detectionRadius?
            *            /  \
            *          TRUE  FALSE
            *          /       \
            *        Follow     Stay still
            *        
            *        
            *        
            *        
            *        
            */
        
    }

    private void Update()
    {
        DTAccao _follow = new DTAccao(() => following = true);
        DTAccao _stop = new DTAccao(() => following = false);

        // Closures
        Vector3 direction = transform.position - target.position;
        float distance = direction.magnitude;

        inRange = new DTCondiccao(() => (distance) <= detectionRadius, _follow, _stop);

        Debug.Log(distance);
        inRange.Run();
    }
}
