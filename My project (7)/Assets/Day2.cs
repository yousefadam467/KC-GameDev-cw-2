using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Day2 : MonoBehaviour
{
    string heroname = "yousef";
    int Heropower = 100;

    string VillianName = "talal";
    int Villianpower = 200;
    float playerspeed = 5.2f;
    // Start is called before the first frame update
    void Start()
    {
        if (Heropower > Villianpower)
        {
            print("Heropower stronger than Villianpower");
        }
        else if (Heropower < Villianpower) 
        {
            print("Villianpower stronger than Heropower");
        } 
        else
        {
            print("Heropower equal Villianpower");
        }
        print(playerspeed);
        Setspeed(2.5);
        print(playerspeed);
    }

    private void Setspeed(double v)
    {
        throw new NotImplementedException();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Setspeed(float speed) 
    { 
        playerspeed = speed;
    }

}
