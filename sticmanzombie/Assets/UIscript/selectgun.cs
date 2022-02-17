using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class selectgun : MonoBehaviour
{
   public  GameObject backgroundgun ;
    public Image selectedgun;
     public Image[] gunsimage = new Image[4];

    getgun guns;


 //************************************************
 
 //************************************************
 void Awake()
    {
        backgroundgun = GameObject.Find("backgroundselectgun");
        
    }


    void Start()
    {
        backgroundgun.SetActive (false);

        guns = GameObject.FindWithTag("Player").GetComponent<getgun>();
    }

    // Update is called once per frame
    void Update()
    {



        for (int i = 0; i <= 3; i++)
        {


            gunsimage[i].sprite = guns.guns[i].GetComponent<SpriteRenderer>().sprite;
           
          
        }

    }



    public void Selectedgun(int i)
    {
selectedgun.sprite = gunsimage[i].sprite;
        Time.timeScale = 1f;

        backgroundgun.SetActive(false);
       
    }


    public void backgroundgunactive()
    {

        if (backgroundgun.activeSelf)
        {
            backgroundgun.SetActive(false);
            Time.timeScale = 1f;

        }
        else
        {
            backgroundgun.SetActive(true);
            Time.timeScale = 0.1f;

        }
    
    }
   
}
