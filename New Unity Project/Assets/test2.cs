using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test2 : MonoBehaviour
{

    
    string heroname = "battman";
    int heropower = 100;

    string shereer = "xman";
    int shereerpower = 50;


    float playerspeed = 4.4;


    void Start()
    {

        if (heropower > shereerpower)
        {
            print("i love battman");
        }

        else if (heropower < shereerpower)
        {
            print("i love shereeer");
        }


        else
        {

            print("i dont like any body");
        }


        void setSpeed(float newSpeed)
        {
            print("old speed is "+  playerspeed);
            playerspeed = newSpeed;

            print("new speed is " + playerspeed) ;

        }
    }

    
    



    
    
        
    
}
