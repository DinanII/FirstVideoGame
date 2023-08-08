using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerMovement movement;

    void OnCollisionEnter (Collision CollisionInfo)
    {
        if(CollisionInfo.collider.tag == "Obstacle")
        {
            Debug.Log("Obstakel geraakt!");
            movement.enabled = false;
            FindObjectOfType<GameManager>().GameOver();
        }
    }
}
