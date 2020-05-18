using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinishPoint : MonoBehaviour
{
   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name.Equals("player") && SceneManager.GetActiveScene() != SceneManager.GetSceneByName("FinalLevel"))
        {
            FindObjectOfType<GameManager>().LoadNextLevel();
        } else
        {
            FindObjectOfType<GameManager>().FinishGame();
        }
    }
}
