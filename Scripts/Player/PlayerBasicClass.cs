using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBasicClass : MonoBehaviour
{
    private float distanceHorizontal;
    private float moveSpeed;
    public float MoveSpeed {
        get => moveSpeed;
        set => moveSpeed = value;
    }

    // 目前自定义的输入系统值有: LeftPlayerHorizontal, RightPlayerHorizontal
    private string axisNameByHorizontal; // 需要手动添加Input Manager的值
    public string AxisNameByHorizontal {
        set => axisNameByHorizontal = value;
    }

    public myMath value;
    
    private Rigidbody2D rig;

    [SerializeField] protected GameObject weapon;
    [SerializeField] protected Transform weaponPos;
    public TMP_Text value_text;

    // Functions

    protected void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    protected void Update() {
        TextManager();

        OnKeyDonwByHorizontal();
        Moving();
    }

    protected virtual void InitData(float _moveSpeed, string _axisNameByHorizontal, myMath _value) {
        moveSpeed = _moveSpeed;
        AxisNameByHorizontal = _axisNameByHorizontal;
        value = _value;
    }

    protected virtual bool IsDead() { return false; }

    protected virtual void Attack() { Debug.Log("Run Attack()"); }

    private bool OnKeyDonwByHorizontal()
    {
        float distanceHorizontalTemp = Input.GetAxis(axisNameByHorizontal);
        distanceHorizontal = distanceHorizontalTemp;
        if(distanceHorizontalTemp == 0) {
            return false;
        }

        transform.localScale = new Vector3(distanceHorizontal, 1, 1);
        return true;
    }

    private void Moving() { 
        if(distanceHorizontal != 0) {
            rig.AddForce(Vector2.right * distanceHorizontal * moveSpeed);
        }
    }

    private void TextManager() {
        value_text.text = value.GetValue();
        value_text.transform.localScale = transform.localScale;
    }

}


public interface IPlayerBasicClass
{
    public void InitData();
}