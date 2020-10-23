using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{

    public Rigidbody2D rb2d;
    public float Speed = 5;
    


    void Start()
    {
        
    }

    
    void Update()
    {

        float h = Input.GetAxis("Horizontal") * Speed;

        float v = Input.GetAxis("Vertical") * Speed;

        rb2d.velocity = new Vector2(h, rb2d.velocity.y);

        rb2d.velocity = new Vector2(v, rb2d.velocity.x);

        
    }

}

