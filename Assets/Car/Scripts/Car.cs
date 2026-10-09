using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
   
    private float driveAxis, brakeAxis, turnAxis;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    //Drive - a public method which takes in an axis value from player and stores value to control forward and backward
    public void Drive(float driveAxis)
    {
        this.driveAxis = Mathf.Clamp(driveAxis, -1f, 1f);
    }
    // Brake - a public method takes axis value from player and stores value to control braking.
    public void Brake(float brakeAxis)
    {
        this.brakeAxis = Mathf.Clamp(brakeAxis, 0f, 1f);
    }
    // turn- a public method takes axis value from player and stores to control turning.
    public void Turn(float turnAxis)
    {
        this.turnAxis = Mathf.Clamp(turnAxis, -1f, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
