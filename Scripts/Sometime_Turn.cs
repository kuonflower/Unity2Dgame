using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sometime_Turn : MonoBehaviour
{
    float angle = 90;
    int maxCount = 100;
    int count = 0;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void FixedUpdate()
    {
        count++;
        if(count == maxCount)
        {
            this.transform.Rotate(0, 0, angle);
            count = 0;
        }
    }

}
