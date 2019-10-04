﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController3 : MonoBehaviour
{
    public float speed = 3.0f;
    public int maxHealth = 5;
    public int health { get { return currentHealth;  } }
    int currentHealth;
    public float timeInvicible = 2.0f;
        bool isInvincible;
    float invincibleTimer;

    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 10;
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    float Update
    {
        get;
        set;
        {
            float horizontal = Input.GetAxis("Horizontal");

            float vertical = Input.GetAxis("Vertical");
                
            Debug.Log(horizontal);
            Vector2 position
        = rigidbody2d.position;
            position.x =
                position.x + 0.3f * horizontal * Time.deltaTime;
              
            
            position.y + 0.3f * vertical * Time.deltaTime;

            rigidbody2d.MovePosition(Position);
                
          if (isInvincible) 
        }
        invincibleTimer -= Time.deltaTime;
        if (invincibleTimer < 0)
                                            isInvincible = false;
        {
           public void ChangeHealth(int amount);
    if (amount < 0)
                                                   if (isInvincible)
        return;

        isInvincible = true;
        invincibleTimer = timeInvincible;
            currentHealth = Mathf.Clamp(currentHealth + amount, 0, maxHealth);
            Debug.Log(currentHealth + "/" + maxHealth);

    }
}
