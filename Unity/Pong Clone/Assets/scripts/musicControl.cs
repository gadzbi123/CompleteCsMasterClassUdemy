using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class musicControl : MonoBehaviour
{
    public AudioSource wallSound;
    public AudioSource racketSound;

    private void OnCollisionEnter(Collision collision)
    {
        if (racketSound || wallSound)
            if (collision.gameObject.name == "RacketP1" || collision.gameObject.name == "RacketP2")
                this.racketSound.Play();
            else
                this.wallSound.Play();
    }
    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

    }
}
