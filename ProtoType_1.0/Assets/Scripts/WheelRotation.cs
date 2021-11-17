using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    public float horizontalRotation;
    public float verticalRotation;
    public float turnSpeed;
     

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        horizontalRotation = Input.GetAxis("Horizontal");
        verticalRotation = Input.GetAxis("Vertical");
        


        //Rotate wheels

        if (horizontalRotation >= -30f && horizontalRotation <= 30f)
        {
            transform.Rotate(Vector3.up);
            
        }

    }
}
