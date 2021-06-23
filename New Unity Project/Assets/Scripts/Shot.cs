using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shot  : MonoBehaviour
{
    private Rigidbody2D MyRb;
    public float Speed;
    private float damage;

    void Start()
    {
        MyRb = GetComponent<Rigidbody2D>();
        damage = 20;
    }

    void Update()
    {
        MyRb.velocity = new Vector2(+Speed, 0);
        Destroy(gameObject, 4f);
    }
    //private void OnTriggerEnter2D(Collider2D collision)
    //{
    //    if( collision.tag.Equals("Enemy")
    //        (collision.GetComponent<MonoBehaviour>()).Damage(damage));  
    //}
    
}
