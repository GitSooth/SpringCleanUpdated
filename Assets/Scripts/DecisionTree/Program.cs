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
            *      closerlonger < 5 ?
            *          /  \
            *      TRUE     FALSE
            *       /       \
            *      Ataque   distancecloser > 3?
            *                  /  \
            *                TRUE  FALSE
            *                /       \
            *              ATTACK     FOLLOW
            */

        float distancelonger =5;
        float distancecloser = 3;

        DTAccao _ataque = new DTAccao(()=> Console.WriteLine("Attack!"));
        DTAccao throw_ = new DTAccao(() =>
          {
              distancecloser--;
              Console.WriteLine("Attack the target");
          });

        DTAccao _run = new DTAccao(() => Console.WriteLine("Follow target"));

        // Closures
        DTCondiccao _distancecloser = new DTCondiccao(() => distancecloser > 0, _ataque, _run);
        _distance = new DTCondiccao(() => distancelonger < 5, _ataque, _distancecloser);

   
     
    }

    private void Update()
    {
        _distance.Run();
      
    }
}
