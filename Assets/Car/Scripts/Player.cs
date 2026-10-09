using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public Car car; // reference to car script
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    private void Update()
    {
        if (!car) return;
        // get input from input class using Getaxis
        // pass update to car script using public methods
        car.Drive(Input.GetAxisRaw("Vertical"));
        car.Drive(Input.GetAxisRaw("Horizontal"));
        car.Brake(Input.GetKey(KeyCode.LeftShift)? 1f : 0f);
        
    }
}
