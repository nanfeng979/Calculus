using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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
    
    private Rigidbody2D rig;

    [SerializeField] private GameObject weapon;
    [SerializeField] private Transform weaponPos;

    // Functions

    protected void Start() {
        rig = GetComponent<Rigidbody2D>();
    }

    protected void Update() {
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

    public bool IsDead()
    {
        return hp <= 0;
    }


    public void Attack() { 
        GameObject weaponTemp = Instantiate(weapon, weaponPos.position, Quaternion.identity, weaponPos);
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

}


public interface IPlayerBasicClass
{
    // public void Attack();
}