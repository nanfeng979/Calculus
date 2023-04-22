using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Integ : PlayerBasicClass, IPlayerBasicClass
{
    new void Start()
    {
        base.Start();
        InitData();
    }

    new void Update()
    {
        base.Update();

        if(Input.GetKeyDown(KeyCode.Keypad1)) {
            Attack();
        }

        if(IsDead()) {
            Destroy(gameObject);
        }
    }

    public void InitData() {
        base.InitData(3.0f, "RightPlayerHorizontal", new myMath(1, 3));
    }
    
    protected override bool IsDead() {
        return value.GetMyMath().Exp < 1;
    }

    protected override void Attack() {
        Debug.Log("Integ is Attack");
    }

}
