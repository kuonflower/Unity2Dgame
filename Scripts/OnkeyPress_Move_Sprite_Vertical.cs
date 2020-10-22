using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnkeyPress_Move_Sprite_Vertical : MonoBehaviour
{
    float vy = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vy = 0;

        if (Input.GetKey("up"))
        {
            vy = 1;
        }
        if (Input.GetKey("down"))
        {
            vy = -1;
        }

    }

    private void FixedUpdate()
    {
        this.transform.Translate(0, vy / 50, 0);
    }
}
