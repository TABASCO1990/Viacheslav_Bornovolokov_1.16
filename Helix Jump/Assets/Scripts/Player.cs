using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scipts;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float BounceSpeed;
    public Rigidbody Rigidbody;
    public Game Game;
    public Platform CurrentPlatform;
    public AudioSource audioBallBouncePlatform, audioBreakPlatform;
    public ParticleSystem smokePartical;
   
    

    //Прыгаем вверх
    public void Bounce()
    {
        Rigidbody.velocity = new Vector3(0, BounceSpeed, 0);
        audioBallBouncePlatform.Play();
    }

    public void Die()
    {
        Game.OnPlayerDied();
        Rigidbody.velocity = Vector3.zero;
        smokePartical.Play();
    }

    public void ReachFinish()
    {
        Game.OnPlayerReachedFinish();
        Rigidbody.velocity = Vector3.zero;
        
    }
}
