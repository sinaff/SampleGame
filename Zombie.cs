using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zombie : MonoBehaviour
{

    public float Health = 100;
    [SerializeField]
    private float Speed = 2;
    private Rigidbody rb;
    private Animator anim;
    bool IsDead;


    private void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody>();
        IsDead = anim.GetBool("IsDead");
    }
    private void Update()
    {
        IsDead = true;
        transform.Translate(0, 0, Speed * Time.deltaTime);
        
    }

    public void TakeDamage(float amount)
    {
        
        Health -= amount;
        if (Health <= 0 )
        {
            IsDead = false;
            Die();
        }
    }

    private void Die()
    {
        Destroy(gameObject,2);

    }
}
