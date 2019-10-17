﻿using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 3.0f;
    public bool vertical;
    public float changeTime = 3.0f;
    Rigidbody2D rigidbody2d;
    float timer;
    int direction = 1;
    bool broken = true;
    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
        timer = changeTime;
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(!broken)
        {
            return;
        }
        timer -= Time.deltaTime;
        if (timer < 0)
            direction = -direction;
        timer = changeTime;
        Vector2 position = rigidbody2d.position;
        if (vertical)
        {
            position.y = position.y + Time.deltaTime * speed;
            animator.SetFloat("Move X", 0);
            animator.SetFloat("Move Y", direction);
        }

        else

        {
            position.x = position.x + Time.deltaTime * speed;
            animator.SetFloat("Move X", direction);
            animator.SetFloat("Move Y", 0);
        }

        rigidbody2d.MovePosition(position);

      void OnCollisionEnter2D(Collision2D other)
        {
            NewBehaviourScript player = other.gameObject.GetComponent<NewBehaviourScript>();
            if (player != null)
            {
                player.ChangeHealth(-1);
            }
        }
}

    public void Fix()
    {
        broken = false;
        rigidbody2d.simulated = false;
        animator.SetTrigger("Fixed");
    }





}



    
    
        
    
