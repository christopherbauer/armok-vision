﻿using UnityEngine;
using System.Collections;

public class TimeHolder : MonoBehaviour {

    public float fixedTime = 11.0f;
    public bool useFixedTime = true;

    public DFTime realTime;
    public DFTime displayedTime;

    void FixedUpdate()
    {
        realTime.CurrentYearTicks ++;
        displayedTime.Year = realTime.Year;
        displayedTime.CurrentYearTicks = realTime.CurrentYearTicks;

        if(useFixedTime)
            displayedTime.DayTicks = (int)(fixedTime * 50);
    }
}
