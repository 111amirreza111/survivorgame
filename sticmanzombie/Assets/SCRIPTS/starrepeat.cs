using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class starrepeat : MonoBehaviour
{
    GameObject[] starts;
    public float maxx, minx, maxy, miny;

    
    void Start()
    {
        starts = GameObject.FindGameObjectsWithTag("star");
    }

    // Update is called once per frame
    void Update()
    {
        float starpos = Random.Range(1f, 10f);
     
        
    }
    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == ("star"))
        {
            float Xpos = Random.Range(minx,maxx);
            float Ypos = Random.Range(miny, maxy);
        

            col.transform.position = new Vector3(col.transform.position.x + Xpos, Ypos , col.transform.position.z);


        }
    }

}
