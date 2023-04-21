using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myMath
{
    public int x;
    public int n;


    public myMath(int x, int n) {
        this.x = x;
        this.n = n;
    }

    public myMath qiudao() {
        this.x *= this.n;
        this.n--;
        return this;
    }

    public void print() {
        Debug.Log(x + "x^" + n);
    }

    public myMath GetMyMath() {
        return this;
    }
}
