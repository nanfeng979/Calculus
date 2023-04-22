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

        value = new myMath(6, 1); // 6x^3
    }

    new void Update()
    {
        base.Update();
        if(Input.GetKeyDown(KeyCode.J)) {
            Attack();
        }

        if(IsDead()) {
            Destroy(gameObject);
        }
    }

    protected override bool IsDead() {
        return value.GetMyMath().Exp > 3;
    }

}
