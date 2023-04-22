using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Integ : PlayerBasicClass
{
    public TMP_Text value_text;

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

        value_text.text = value.GetValue();

        if(IsDead()) {
            Destroy(gameObject);
        }
    }
    
    protected override bool IsDead() {

        return value.GetMyMath().Exp < 1;
    }

}
