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
    }

    new void Update()
    {
        base.Update();

    }


}
