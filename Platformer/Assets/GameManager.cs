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
    bool HasEnded = false;
    public void LoadNextLevel()
    {

        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        SceneManager.MoveGameObjectToScene(GameObject.FindGameObjectWithTag("fullTimer"), SceneManager.GetSceneByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1));
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(SceneManager.GetActiveScene().buildIndex + 1));
    }

    public void FinishGame()
    {
        HttpClient httpClient = new HttpClient();
        Debug.Log(Environment.MachineName);
        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();

 
        httpClient.GetAsync("localhost:5555/highscoreSet?name=" + Environment.MachineName + "time=" + timerScript.getTime());
      

        Death();

    }

    public void Death()
    {
        SceneManager.LoadScene("Level1");
        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        timerScript.Reset();
    }

    public void Start()
    {
        GameObject UI = GameObject.FindGameObjectWithTag("userInterface");
        UI.SetActive(false);

        GameObject timer = GameObject.FindGameObjectWithTag("timerText");
        TimerScript timerScript = timer.GetComponent<TimerScript>();
        timerScript.startTimer();
    }
}
