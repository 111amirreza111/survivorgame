using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uizombie : MonoBehaviour
{
    public Rigidbody2D zombie;
    public float speed;
  
    void Start()
    {
        zombie = GetComponent<Rigidbody2D>();
      
    }

    // Update is called once per frame
    void Update()
    {
        zombie.velocity = Vector2.left * speed;
    }
}
