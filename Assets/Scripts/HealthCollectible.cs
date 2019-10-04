using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
    RubyController3 controller = other.GetComponent<RubyController2>();

    if (controller ! = null)
        if(controller.health <controlller.maxHealth);
        {

        controller.ChangeHealth(1);
        
       Destroy(GameObject);

        Debug.Log("Object that entered the trigger : " + other );
    }

    // Update is called once per frame
    v
    {
        
    }
}
