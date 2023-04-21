using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integ : PlayerBasicClass
{

    public myMath myMath_1;
    new void Start()
    {
        base.Start();
        Hp = 5;
        MoveSpeed = 3.0f;
        AxisNameByHorizontal = "RightPlayerHorizontal";

        myMath_1 = new myMath(1, 3); // x^3

    }

    new void Update()
    {
        base.Update();

        if(myMath_1.n <= 0) {
            Destroy(gameObject);
        }

    }


}
