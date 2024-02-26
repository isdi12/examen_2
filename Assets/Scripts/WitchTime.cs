using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WitchTime : MonoBehaviour
{
   
    public AudioClip Timer;
    public AudioSource src;
    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
        Time.timeScale = 0.25f;
        src = AudioManager.instance.PlayAudio(Timer, "witchTime");

            StartCoroutine(TimeOut()); 
        }
    }
    IEnumerator TimeOut()
    {
        Time.timeScale = 0.25f;
        while (src && src.isPlaying)
        {
            yield return null;
        }
        Time.timeScale = 1f;

    }
}
