using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider2D))]

public class BounderyCollioder : MonoBehaviour
{
    //on trigger 2d
    private void OnTriggerEntry2D(Collider2D collision)
    {
        //this destroys the enemy off screen
        var enemy = collision.GetComponent<Enemy>();
        if(enemy)
        {
            Destroy(enemy.gameObject);
        }

        //this destroys the bullet off screen
        var bullet = collision.GetComponent<Bullet>();
        if(bullet)
        {
            Destroy(bullet.gameObject);
        }
    }
}
