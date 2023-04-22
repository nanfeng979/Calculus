using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerBasicClass : MonoBehaviour
{
    public int hp;
    public int Hp {
        get => hp;
        set => hp = value;
    }
    private float distanceHorizontal;
    private float moveSpeed;
    public float MoveSpeed {
        get => moveSpeed;
        set => moveSpeed = value;
    }

    private string axisNameByHorizontal;
    public string AxisNameByHorizontal {
        set => axisNameByHorizontal = value;
    }

    public myMath value;
    
    private Rigidbody2D rig;

    [SerializeField] private GameObject weapon;
    [SerializeField] private Transform weaponPos;
    public TMP_Text value_text;

    // Functions

    protected void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    protected void Update() {
        textManager();

        if(distanceHorizontal != 0) {
            transform.localScale = new Vector3(distanceHorizontal, 1, 1);
        }

        OnMoveByHorizontal();
        Moving();
    }

    public void TakeDamage(int damage)
    {
        hp -= damage;
    }

    public void Heal(int heal)
    {
        hp += heal;
    }

    protected virtual bool IsDead()
    {
        return false;
    }

    protected virtual void Attack() { 
        Instantiate(weapon, weaponPos.position, Quaternion.identity, weaponPos);
    }

    private bool OnMoveByHorizontal()
    {
        float distanceHorizontalTemp = Input.GetAxis(axisNameByHorizontal);
        if(distanceHorizontalTemp != 0) {
            distanceHorizontal = distanceHorizontalTemp;
            return true;
        }
        distanceHorizontal = 0;
        return false;
    }

    private void Moving() { 
        if(distanceHorizontal != 0) {
            rig.AddForce(Vector2.right * distanceHorizontal * moveSpeed);
        }
    }

    private void textManager() {
        value_text.text = value.GetValue();
        value_text.transform.localScale = transform.localScale;
    }

}


public interface IPlayerBasicClass
{
    // public void Attack();
}