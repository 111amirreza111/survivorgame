using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorrepeat : MonoBehaviour
{





    public float aa;

    // Start is called before the first frame update
    void Start()
    {
    
     

    }

    // Update is called once per frame
    void Update()
    {
      
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("floor"))
        {


            col.transform.position = new Vector2(col.transform.position.x + aa, col.transform.position.y);
           

        }
    }
}
