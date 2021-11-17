using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject tank;
    private Vector3 cameraOffset = new Vector3 (0,9.2f,-11.7f);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()  
    {
        //Change view based on Tank location
        transform.position = tank.transform.position + cameraOffset;
    }
}
