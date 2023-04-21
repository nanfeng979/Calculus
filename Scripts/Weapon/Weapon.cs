using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    void Update()
    {
        transform.Translate(Vector2.right * Time.deltaTime * 1.0f);
    }

    private void OnTriggerEnter2D(Collider2D other) {
        if(other.name == "Integ") {
            Destroy(gameObject);
            other.GetComponent<Integ>().myMath_1.qiudao();
        }
    }
}
