using System.Collections;
using System.Collections.Generic;
using System.Net.Http;
using UnityEngine;
using UnityEngine.UI;

public class LoadUsers : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        HttpClient httpClient = new HttpClient();
        var result = httpClient.GetAsync("http://localhost:5555/highscore").Result;

        var contents = result.Content.ReadAsStringAsync().Result;

        Debug.Log(contents.ToString());
        GameObject textfield = GameObject.FindGameObjectWithTag("highscore");
        textfield.GetComponentInChildren<Text>().text = contents;

    }
}
