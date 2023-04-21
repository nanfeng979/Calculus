using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integ : PlayerBasicClass
{
    new void Start()
    {
        base.Start();
        Hp = 5;
        MoveSpeed = 3.0f;
        AxisNameByHorizontal = "RightPlayerHorizontal";

        value = new myMath(1, 3); // x^3
    }

    new void Update()
    {
        base.Update();

        if(IsDead()) {
            Destroy(gameObject);
        }
    }
    
    protected override bool IsDead() {

        return value.GetMyMath().Exp < 1;
    }

}
