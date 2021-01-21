using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Program : MonoBehaviour
{

    DTNode _distance;
     void Start()
    {
        /*
            *       Targetrange < 5 ?
            *          /  \
            *      TRUE   FALSE
            *       /       \
            *    Follow   distancecloser > 3?
            *                  /  \
            *                TRUE  FALSE
            *                /       \
            *              ATTACK     FOLLOW
            */

        float distancelonger =5;
        float distancecloser = 3;

        DTAccao _follow = new DTAccao(()=> Debug.Log("Follow target"));
        DTAccao _Attack = new DTAccao(() =>
          {
              distancecloser--;
              Debug.Log("Attack the target");
          });

        DTAccao _run = new DTAccao(() => Debug.Log("Follow target"));

        // Closures
        DTCondiccao _distancecloser = new DTCondiccao(() => distancecloser > 0, _follow, _run);
        _distance = new DTCondiccao(() => distancelonger < 5, _follow, _distancecloser);

   
     
    }

    private void Update()
    {
        _distance.Run();
    }
}
