using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
    
    GameManager gm;



    private void Start()
    {
        gm = new GameManager();
    }





    private void OnTriggerEnter2D(Collider2D collision)
    {
       
        if (collision.gameObject.name.Equals("player") && SceneManager.GetActiveScene() != SceneManager.GetSceneByName("FinalLevel"))
        {
            
            gm.LoadNextLevel();
        } else
        {
            gm.FinishGame();
        }
    }
}
