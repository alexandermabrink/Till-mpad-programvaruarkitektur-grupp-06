using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartGame : MonoBehaviour
{
    GameManager gm = new GameManager();

    public void onClick() {
        gm.Start();
    }
}
