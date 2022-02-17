using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class uiblood : MonoBehaviour
{

    public GameObject blood;
    void startt()
    {
        blood.SetActive(true);
    }
    void Start()
    {
       Invoke("startt", 2);
    }
  
}
    
