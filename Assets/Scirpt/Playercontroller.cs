using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playercontroller : MonoBehaviour
{
    public float moveForce;
    
    Vector2 moveDir;
    //able to change character's direction
    Rigidbody2D rb;

   
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

   
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        moveDir= new Vector2(h,v).normalized;
        
    }

    private void FixedUpdate()
    {
        rb.AddForce(moveDir * moveForce);
        //give a force to character and able to make character move
    }
}
