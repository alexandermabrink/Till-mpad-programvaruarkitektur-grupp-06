using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip playerDead, playerJump;
    static AudioSource audioSrc;

    // Start is called before the first frame update
    void Start()
    {
        
        playerJump = Resources.Load<AudioClip>("playerJump");
        playerDead = Resources.Load<AudioClip>("playerDead");

        audioSrc = GetComponent<AudioSource>();
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
                audioSrc.PlayOneShot(playerJump);
                break;
        }
    }


        
}
