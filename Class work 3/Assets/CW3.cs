using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CW3 : MonoBehaviour
{
    string heroname = "zuperman";
    int heropower = 100;
    string villanname = "spongbob";
    int villanpower = 20;
    float playerspeed = 10f;
    float playerspeed2 = 0f;
    
    
    void comparespeed()
    {
        if (playerspeed > playerspeed2)
        {
            print(playerspeed);

        }

        else if (playerspeed == playerspeed2)
                print(playerspeed + "equals" + playerspeed2);

        else
        {
            print(playerspeed);

        }

    }
    
    
    
    
    
    
    void setspeed(float newspeed)
    {
        playerspeed = newspeed;


    }
    // Start is called before the first frame update
    void Start()
    {
        if (heropower > villanpower)
        {
            print(heroname + " is stronger than " + villanname);
        }
        print(playerspeed);
        setspeed(2.5f);
        print(playerspeed);
        comparespeed();
    }

    // Update is called once per frame
    void Update()
    {

    }



}
