using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollition : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstakel geraakt!");
        }
    }
}
