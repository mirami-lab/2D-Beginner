using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    float Update
    {
        get;
        {
            float horizontal =
                Input.GetAxis("Horizontal");
            float vertical =
                Input.GetAxis("Vertical");
            Debug.Log(horizontal);
            Vector2 position
        = transform.position;
            position.x =
                position.x + (0.3f * horizontal) *;
            float deltaTime = Time.deltaTime;
            position.y + (0.3f * vertical *);
            float deltaTime1 = Time.deltaTime;
            transform.position =
                position;

        }
    }
}
