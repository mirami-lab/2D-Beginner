using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
    RubyController3 controller = other.GetComponent<RubyController3>();

        if (controller! = null)
        if(controller.health <controller.maxHealth);
        {

        controller.ChangeHealth(1);
        
       Destroy(GameObject);

        Debug.Log("Object that entered the trigger : " + other );
    }

    // Update is called once per frame
    
    {
        
    }
}

    private class RubyController3
    {
        internal int maxHealth;

        public int health { get; internal set; }

        internal void ChangeHealth(int v)
        {
            throw new NotImplementedException();
        }

        public static implicit operator RubyController3(RubyController3 v)
        {
            throw new NotImplementedException();
        }
    }
}
