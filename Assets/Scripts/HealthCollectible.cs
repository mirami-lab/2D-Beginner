using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D other)
    {
        NewBehaviourScript controller = other.GetComponent<NewBehaviourScript>();

        if (controller != null)
        {
#pragma warning disable CS0642 // Possible mistaken empty statement
            if (controller != null) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        }
        {
            controller.ChangeHealth(1);
            Destroy(gameObject);
        }
    }
    }
        

        
        
       

        
    

    // Update is called once per frame
    
    
        
    


    
    
        

        

        
        
            
        

        
        
            
        
    

