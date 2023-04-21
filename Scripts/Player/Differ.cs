using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// public class Differ : PlayerBasicClass, IPlayerBasicClass
public class Differ : PlayerBasicClass
{
    
    new void Start()
    {
        base.Start();
        Hp = 4;
        MoveSpeed = 3.0f;
        AxisNameByHorizontal = "LeftPlayerHorizontal";
    }

    new void Update()
    {
        base.Update();
        if(Input.GetKeyDown(KeyCode.J)) {
            Attack();
        }
    }

}
