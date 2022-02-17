using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class timer : MonoBehaviour
{
    Text Timer;
    float shownumber;
    public int startnumber;
    void Awake()
    {
        Timer = GetComponent<Text>();
    }

    void Start()
    {
        shownumber = startnumber;


    }

    // Update is called once per frame
    void Update()
    {



        shownumber -= 1 * Time.deltaTime;
        if (shownumber > 0)
        { Timer.text = shownumber.ToString("0"); }
    }
}
