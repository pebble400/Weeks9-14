using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cookbar : MonoBehaviour
{
    //script for the slider component 
    Slider slider;

    
    public float timerLength = 1;
    public float t;
    //public float underCooked = 0.2f;
    //public float perfectCooked = 0.5f;
    //public float overCooked = 0.7f;
    //public Slider visuals;
    //float time = 0;


    void Start()
    {
        slider = GetComponent<Slider>();
    }

    // Update is called once per frame

}
