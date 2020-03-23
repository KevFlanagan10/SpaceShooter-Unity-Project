using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
   //== private methods ==
   private void OnTriggerEnter2D(Collider2D whatHitMe)
    {
        // parameter = what ran into me
        // if the player hit, then destroy the player
        // and the current enemy rectangle 

        var player = whatHitMe.GetComponent<PlayerMovement>();
        var bullet = whatHitMe.GetComponent<Bullet>();

        Debug.Log("Hit Something");

        if(player) //if (player != null)
        {
            Debug.Log("It was the player");
            //play crash sound here
            //destroy the player and the retrangle 
            //give the player points/coins
            Destroy(player.gameObject);
            Destroy(gameObject);
           
        }

        if(bullet)
        {
            //player die sound
            //give the player points
            //destroy the bullet
            Destroy(bullet.gameObject);
            //publish the event to the system to give play points
            PublishEnemyKilledEvent();
            //destroy this game object
            Destroy(gameObject);
        }

    }

    private void PublishEnemyKilledEvent()
    {
        EnemyKilledEvent(this);
    }
}
