using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour


{

    public Text timerLabel;
    private float time;
    private Boolean startTime = false;
    void Start()
    {
     
    }

    void Update()
    {

        if (startTime)
        { 
            time += Time.deltaTime;
            timerLabel.text = "Time: " + string.Format("{00}", time);

        }
    }

    public void startTimer() {
        startTime = true;
    }

    public void Reset()
    {
        startTime = false;
        time = 0;
    }

    public string getTime() {
        return Math.Round(time).ToString();
    }
}
