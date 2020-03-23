using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//move left when this is called

[RequireComponent(typeof(Rigidbody2D))]
public class emenyBehavior : MonoBehaviour
{
    //==private feilds==
    private Rigidbody2D rb;

    // Start is called before the first frame update
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.velocity = new Vector2(-1, 0);
    }
}
