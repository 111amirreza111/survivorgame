using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obrepeat : MonoBehaviour
{
    public float mindistance;
    public float maxdistance;
    float aa;
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
        aa = Random.Range(mindistance, maxdistance);

        if (col.CompareTag("OB"));
        {


            col.transform.position = new Vector2(col.transform.position.x + aa, col.transform.position.y);


        }
    }
}
