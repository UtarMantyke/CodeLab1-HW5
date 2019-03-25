﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float MoveSpead;

    public KeyCode leftKey;
    public KeyCode rightKey;
    public KeyCode upKey;
    public KeyCode downKey;

    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newForce = new Vector2(0, 0); //the force we will add to our player


        if (Input.GetKey(leftKey)) //When someone presses "A"
        {
            newForce.x -= MoveSpead;
        }

        if (Input.GetKey(rightKey)) //When someone presses "D"
        {
            newForce.x += MoveSpead;
        }
        
        if (Input.GetKey(upKey)) //When someone presses "W"
        {
            newForce.y += MoveSpead;
        }
        
        if (Input.GetKey(downKey)) //When someone presses "S"
        {
            newForce.y -= MoveSpead;
        }

        rb.AddForce(newForce);

    }
}
