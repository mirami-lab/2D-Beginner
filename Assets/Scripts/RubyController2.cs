using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RubyController2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QualitySettings.vSyncCount = 0;
            Application.targetFrameRate = 10;
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal =
            Input.GetAxis("Horizontal");
        float vertical =
            Input.GetAxis("Vertical");
            Debug.Log(horizontal);
        Vector2 position
    = transform.position;
        position.x =
            position.x + 0.3f * horizontal *;
        Time.deltaTime;
        position.y + 0.3f * vertical *;
        Time.deltaTime;
        transform.position =
            position;

    }
}
