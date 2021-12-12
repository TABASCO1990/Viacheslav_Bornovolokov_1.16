using System.Collections;
using System.Collections.Generic;
using UnityEditor.Timeline.Actions;
using UnityEngine;

public class BtnFX : MonoBehaviour
{
    public AudioSource myFx;
    public AudioClip clickFx;
    private Game obj;
    
    public void OnClick()
    {
        myFx.PlayOneShot(clickFx);
    }

}
