using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pausepanel : MonoBehaviour
{

    public  GameObject stoppanel;
    public Animator moveanimation;
   

    //************************************************
    public void pause()
    {
        moveanimation.SetBool("stop", true);
        Invoke("time", 0.5f);
        
    } 

    public void resume()
    { 
        
        Time.timeScale = 1f;
        moveanimation.SetBool("resume", true);
        Invoke("resumestopanim", 0.5f);
       

    }
    void time()
    {
        moveanimation.SetBool("stop", false);
        Time.timeScale = 0;
    }
    void resumestopanim()
    {
        moveanimation.SetBool("resume", false);
      
    }
    //***********************************************



}
