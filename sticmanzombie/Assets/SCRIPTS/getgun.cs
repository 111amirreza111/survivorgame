using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getgun : MonoBehaviour
{
public GameObject[] guns = new GameObject[4];
    GameObject handgetbutton, tempgun;
    public GameObject selectedgun ;
    GameObject backgroundguns;
    int gunsi;

   //************************************************
   public void Selectedgun(int i)
    {
        selectedgun = guns[i];
        gunsi = i;
    }
    //************************************************
    void Awake()
    {
        backgroundguns = GameObject.Find("backgroundselectgun");

        handgetbutton = GameObject.Find("handgetbutton");
    }

    void Start()
    {
        handgetbutton.SetActive(false);
       
    }

    // Update is called once per frame
    void Update()
    {
        backgroundguns.GetComponent<selectgun>().selectedgun.sprite = selectedgun.GetComponent<SpriteRenderer>().sprite;
    }
    void OnTriggerEnter2D(Collider2D col)
    {
   
      
     tempgun = col.gameObject;


        if(col.gameObject.tag == "guns" )
        {
            handgetbutton.SetActive(true);
        }
        else
        {
            handgetbutton.SetActive(false);
        }

    }

    public void getgunfunction()
    {
        for (int i = 0; i <guns.Length; i++)
        {
           if( guns[i] == null)
            {
                guns[i] = tempgun;
                selectedgun = tempgun;
                gunsi = i;
                break;
            }
            else
            {
                guns[gunsi] = tempgun;
                selectedgun = tempgun;
            }
        }
    }
}
