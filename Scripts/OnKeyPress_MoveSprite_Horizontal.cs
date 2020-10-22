using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnKeyPress_MoveSprite_Horizontal : MonoBehaviour
{

    float vx = 0;
    bool leftFlag = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        vx = 0;

        if (Input.GetKey("right"))
        {
            vx = 1;
            leftFlag = false;
        }
        if (Input.GetKey("left"))
        {
            vx = -1;
            leftFlag = true;
        }
    }

    private void FixedUpdate()
    {
        this.transform.Translate(vx / 50, 0, 0);

        this.GetComponent<SpriteRenderer>().flipX = leftFlag;
    }
}
