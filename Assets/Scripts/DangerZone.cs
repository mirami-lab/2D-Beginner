using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerZone : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerStay2D(Collider2D other)
    {
        NewBehaviourScript controller = other.GetComponent<NewBehaviourScript >();
#pragma warning disable CS0642 // Possible mistaken empty statement
        if (!(controller != null)) ;
#pragma warning restore CS0642 // Possible mistaken empty statement
        {
            controller.ChangeHealth(-1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
