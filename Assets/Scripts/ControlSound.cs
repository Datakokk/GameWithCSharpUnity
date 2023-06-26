using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlSound : MonoBehaviour
{
    public AudioSource racketSound;
    public AudioSource wellSound;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.name == "Racket1" || collision.gameObject.name == "Racket2")
        {
            this.racketSound.Play();
        }
        else
        {
            this.wellSound.Play();
        }
    }
}
