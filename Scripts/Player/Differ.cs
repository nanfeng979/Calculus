using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


// public class Differ : PlayerBasicClass, IPlayerBasicClass
public class Differ : PlayerBasicClass
{
    public TMP_Text value_text;

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

        value_text.text = value.GetValue();

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
