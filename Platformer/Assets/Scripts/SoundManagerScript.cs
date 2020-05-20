using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerDead, playerJump, playerLand,nextLevel,music;
    public static AudioSource audioSrc, musicSrc;
    private static bool created = false;

    private void Awake()
    {
        if (!created)
        {
            DontDestroyOnLoad(this.gameObject);
            created = true;
        }
        else
        {
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
        playerJump = Resources.Load<AudioClip>("playerJump");
        playerDead = Resources.Load<AudioClip>("playerDead");
        playerLand = Resources.Load<AudioClip>("playerLand");
        nextLevel = Resources.Load<AudioClip>("Sweep");
        music = Resources.Load<AudioClip>("Music");

        audioSrc = GetComponent<AudioSource>();
        musicSrc = GetComponent<AudioSource>();

        musicSrc.loop = true;
        musicSrc.clip = music;
        musicSrc.Play();



    }

    // Update is called once per frame
    void Update()
    {
      

    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "playerJump":
                audioSrc.PlayOneShot(playerJump);
                break;
            case "playerDead":
                audioSrc.PlayOneShot(playerDead);
                break;
            case "playerLand":
                audioSrc.PlayOneShot(playerLand);
                break;
            case "nextLevel":
                audioSrc.PlayOneShot(nextLevel);
                break;
        }
    }

}
