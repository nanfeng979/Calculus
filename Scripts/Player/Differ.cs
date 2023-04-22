using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Differ : PlayerBasicClass, IPlayerBasicClass
{
    new void Start()
    {
        base.Start();
        InitData();
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

    public void InitData() {
        base.InitData(3.0f, "LeftPlayerHorizontal", new myMath(6, 1));
    }

    protected override bool IsDead() {
        return value.GetMyMath().Exp > 3;
    }

    protected override void Attack() {
        
    }

}
