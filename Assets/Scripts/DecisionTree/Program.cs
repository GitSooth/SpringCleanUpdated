using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Program : MonoBehaviour
{
    public Transform target;
    float detectionRadius = 5f, attackRadius = 1f;
    float distance;
    public bool following = false, attack = false;
    DTCondiccao inRange, isAttacking;

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
        DTAccao _attack = new DTAccao(() => attack = true);
        DTAccao _stopAttacking = new DTAccao(() => attack = false);

        // Closures
        Vector3 direction = transform.position - target.position;
        float distance = direction.magnitude;

        inRange = new DTCondiccao(() => (distance) <= detectionRadius, _follow, _stop);
        isAttacking = new DTCondiccao(() => (distance) <= attackRadius, _attack, _stopAttacking);
        
        inRange.Run();
        isAttacking.Run();
    }
}
