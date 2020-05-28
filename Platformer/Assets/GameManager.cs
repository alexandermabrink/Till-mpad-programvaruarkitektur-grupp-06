using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.SceneManagement;
using Microsoft.VisualBasic;
using System;

public class GameManager : MonoBehaviour

{      
    
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FinishGame()
    {

        //Getting time and sending to server
        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        HttpClient httpClient = new HttpClient();
        if (timerScript.getTime() != "0" ) { 
        httpClient.GetAsync("http://amirs.pro:5555/highscoreSet?name=" + Environment.MachineName + "&time=" + timerScript.getTime());
        Debug.Log("http://localhost:5555/highscoreSet?name=" + Environment.MachineName + "&time=" + timerScript.getTime());
        }
      

        Death();

    }

    public void Death()
    {
        
        //loading first level
        SceneManager.LoadScene("Level1");
        //resetting time
        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        timerScript.Reset();
       

    }

    public void Start()
    {
        
        //Removing UI after start pressed
        GameObject UI = GameObject.FindGameObjectWithTag("userInterface");
        UI.SetActive(false);

        //Starting timer
        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        timerScript.startTimer();
    }
}
