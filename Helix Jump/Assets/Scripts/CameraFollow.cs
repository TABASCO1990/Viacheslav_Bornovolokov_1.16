using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Player Player;
    public Vector3 PlatformToCameraOffset;
    public float Speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(Player.CurrentPlatform == null) return;
        Vector3 targetPosition = Player.CurrentPlatform.transform.position + PlatformToCameraOffset;
        transform.position = Vector3.MoveTowards(transform.position,targetPosition, Speed *Time.deltaTime);
    }
}
