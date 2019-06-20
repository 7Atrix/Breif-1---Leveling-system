﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelingSystem : MonoBehaviour
{
    public int level;
    public float experience;
    private float experiencerequired;
   
    //Empty Functions
    public float hp;

   
    void Start()
    {
        level = 1;
        hp = 100;
        experience = 0;
        experiencerequired = 100;
    }
   
    void Update()
    {
        Exp();

        if(Input.GetKeyDown(KeyCode.F))
        {
            experience += 100;
        }
    }

    void LevelUp()
    {
        level = 1;
        experience = 0;

        switch (level) //HP scaling
        {
            case 2:
                hp = 200;
                experiencerequired = 200;
                print("Level 2!");
                break;

            case 3:
                hp = 300;
                experiencerequired = 300;
                print("Level 3!");
                break;
        }
           
    }

    void Exp()
    {
        if (experience >= experiencerequired)
            LevelUp();
        
    }
}
