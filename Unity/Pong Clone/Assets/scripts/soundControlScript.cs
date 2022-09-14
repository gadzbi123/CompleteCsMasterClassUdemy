using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundControlScript : MonoBehaviour
{

    public AudioSource music;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (music)
                if (music.isPlaying)
                    music.Stop();
                else music.Play();
        }
    }
}
