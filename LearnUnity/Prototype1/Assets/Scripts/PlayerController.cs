using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float SpeedVehicle = 10.0f;
    private float turnSpeed=25.0f;
    private float HorizontalInput;
    private float VerticalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HorizontalInput = Input.GetAxis("Horizontal");
        VerticalInput = Input.GetAxis("Vertical");
        //Move Forward
      
        transform.Translate(Vector3.forward*Time.deltaTime*SpeedVehicle*VerticalInput);
     // transform.Translate(Vector3.right*Time.deltaTime * turnSpeed*HorizontalInput);
        transform.Rotate(Vector3.up, Time.deltaTime * turnSpeed * HorizontalInput);
    }
}
