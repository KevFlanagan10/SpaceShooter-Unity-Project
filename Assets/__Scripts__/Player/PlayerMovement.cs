using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Transform t;
    //creates a slider from 1 - 10 for speed
    //[SerializeField] [Range(1.0f, 10.0f)]
    private float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        float vMovement = Input.GetAxis("Vertical");
        float hMovement = Input.GetAxis("Horizontal");
        rb.velocity = new Vector2(vMovement * speed, hMovement * speed);

        //keep the player on the screen
        // float xValue = Mathf.Clamp(value, min, max)
        // rb.position.x

        //stops the player going off the screen at the top & bottom
        float yValue = Mathf.Clamp(rb.position.y, -6.0f, 6.0f);
       // rb.position = new Vector2(rb.position.x, yValue);

         //stops the player going off the screen on the left & right
        float xValue = Mathf.Clamp(rb.position.x, -11.0f, 11.0f);
       // rb.position = new Vector2(rb.position.y, xValue);
        
        rb.position = new Vector2(xValue,yValue);


        //The player moves with the direcional arrows
        if (Input.GetKeyDown(KeyCode.Space))
        {
           // fireBullet();
        } 
        if (Input.GetKeyUp(KeyCode.Space))
        {
           // stopFire();
        }
    }//end of if
    
}
