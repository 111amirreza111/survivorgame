using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movecar : MonoBehaviour
{
           GameObject player;
           Rigidbody2D rigid;
           Vector2 movevector;
    public float speed;
    public Joystick joustickk;
  
 //*********************************************************
    public void increasespeed()
    {
        speed = 10;
    }
    public void decreasespeed()
    {
        speed = 2;
    }
    //*******************************************************
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        rigid = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
       
       
    }

  
    void FixedUpdate()
    {

        movevector = new Vector2(joustickk.Horizontal ,0);
        rigid.velocity = movevector * speed;

       
    }
}
