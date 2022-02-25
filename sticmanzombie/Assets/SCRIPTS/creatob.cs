using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class creatob : MonoBehaviour
{
     public GameObject[] OB  = new GameObject[2];
    Transform posone, postwo;


    float randon ;
    int randominstan;
    void Awake()
    {
       posone= GameObject.Find("leftwallforOB").transform;
        postwo = GameObject.Find("rightwallforOB").transform;
       
        for (int i = 0; i < 20; i++)
        {

            randominstan = Random.Range(0,2);
            randon = Random.Range(posone.position.x + 15f, postwo.position.x - 15f);

            Instantiate(OB[randominstan] , new Vector3(randon , OB[randominstan].transform.position.y , 1f) , Quaternion.identity);

        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

     
    }
}
