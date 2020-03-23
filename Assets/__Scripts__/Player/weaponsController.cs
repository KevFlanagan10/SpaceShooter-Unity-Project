using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weaponsController : MonoBehaviour
{
    //==private fields==
    [SerializeField] private float bulletSpeed = 5.0f;
    [SerializeField] private Bullet bulletPrefab;
    
    //==private methods==
    void Update()
    {
    
        if (Input.GetKeyDown(KeyCode.Space))
        {
            FireBullet();
        }

    }

    private void FireBullet()
    {
        //instantiate bullet
        Bullet bullet = Instantiate(bulletPrefab);
        //give it the same position as the player
        bullet.transform.position = transform.position;
        //give it velocity and move right
        Rigidbody2D rbb = bullet.GetComponent<Rigidbody2D>();
        //rbb.velocity = new Vector2(1 * speed, 0);
        rbb.velocity = Vector2.right * bulletSpeed;

    }

}
