using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMath
{
    private int coefficient; // 系数
    public int Coeff {
        get => coefficient;
        set => coefficient = value;
    }

    private int exponential; // 指数
    public int Exp {
        get => exponential;
        set => exponential = value;
    }

    public myMath(int coff, int exp) {
        Coeff = coff;
        Exp = exp;
    }

    public myMath differentical() { // 微分
        Coeff *= Exp;
        Exp--;
        return this;
    }

    public myMath integral() { // 积分
        Exp++;
        Coeff /= Exp;
        return this;
    }

    public void printData() {
        Debug.Log(Coeff + "x^" + Exp);
    }

    public myMath GetMyMath() {
        return this;
    }
}
