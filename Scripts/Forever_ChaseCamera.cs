using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Forever_ChaseCamera : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        Vector3 pos = this.transform.position;
        
        pos.x += 3;
        pos.y += 3;
        pos.z = -10;

        Camera.main.gameObject.transform.position = pos;
    }
}
