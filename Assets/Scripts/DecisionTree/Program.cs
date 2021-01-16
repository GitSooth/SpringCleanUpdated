using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Program 
{
    static void Main(string[]Main)
    {
        /*
             *      closerlonger < 5 ?
             *          /  \
             *      TRUE     FALSE
             *       /       \
             *    SHOOT     distancecloser > 0?
             *                  /  \
             *                TRUE  FALSE
             *                /       \
             *              THROW     RUN
             */

        float distancelonger=5;
        float distancecloser = 5;

        DTAccao _ataque = new DTAccao(()=> Console.WriteLine("Attack!"));
        DTAccao throw_ = new DTAccao(() =>
          {
              distancecloser--;
              Console.WriteLine("Attack the target");
          });

        DTAccao _run = new DTAccao(() => Console.WriteLine("Move target"));

        // Closures
        DTCondiccao _distancecloser = new DTCondiccao(() => distancecloser > 0, _ataque, _run);
        DTCondiccao _distance = new DTCondiccao(() => distancelonger < 5, _ataque, _distancecloser);

        _distance.Run();
        distancelonger = 10;
        _distance.Run();
        distancecloser++;
        _distance.Run();
        _distance.Run();
    }
}
