using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool HasEnded = false;
    public void LoadNextLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void FinishGame()
    {

    }

    public void Death()
    {
        SceneManager.LoadScene("Level1");
    }

    public void Start()
    {
        SceneManager.LoadScene("Level1");
    }
}
