﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roulettecontroller : MonoBehaviour
{


    float rotspeed = 0.0f;
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            this.rotspeed = 30.0f;
        }
        if (Input.GetMouseButtonDown(1))
        {
            this.rotspeed = 0.0f;
        }
        this.rotspeed *= 0.987f;
        transform.Rotate(0, 0, this.rotspeed);
    }
}
