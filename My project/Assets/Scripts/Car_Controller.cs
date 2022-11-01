using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car_Controller : MonoBehaviour
{

    public int wheels = 4;

    public float speed = 42f;

    string carName = "Carlos";

    public bool isCarOn = true;

    // Start is called before the first frame update
    void Start()
    {
        print("my car is called: " + carName);
        print("my car has " + wheels + " wheels");

        if (isCarOn)
        {
            print("the car is on");
        }
        else
        {
            print("the car is not on");
        }

        if (speed > 9000)
        {
            print("it's over 9000!");
        }
        else if (speed <= 9000 && speed > 100)
        {
            print("goodness gracious such speed");
        }
        else
        {
            print("wow we're real slow");
        }
        while (speed < 4)
        {
            speed =(speed - 1);
            print ("The car's speed is now" +speed);
        }

        //

        // Update is called once per frame
        void Update()
        {

        }
    }
}
