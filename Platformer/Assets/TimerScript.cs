using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour


{

    public Text timerLabel;
    private float time;
    // Start is called before the first frame update
    void Start()
    {
     
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;

        var minutes = time / 60;
        var seconds = time % 60;
        var fraction = (time * 100) % 100;

        //update the label value
        timerLabel.text = string.Format("{0:00} : {1:00} : {2:00}", minutes, seconds, fraction);
    }
}
