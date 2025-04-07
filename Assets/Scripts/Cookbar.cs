using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.Events;

public class Cookbar : MonoBehaviour
{
    //script for the slider component 
    Slider slider;

    public UnityEvent OnCookingHasFinished;
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
    public void FoodIsCooked ()
    {
        t += Time.deltaTime;
        if (t > timerLength)
        {
            t = 0;
            OnCookingHasFinished.Invoke();
        }
        if (t == 1)
        {
            Debug.Log("Food's done.");
        }

    }
}
