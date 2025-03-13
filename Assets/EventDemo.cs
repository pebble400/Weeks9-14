using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class EventDemo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if(t > timerLength)
        {
            t = 0;
            OnTimerHasFinished.Invoke();
        }
        
    }


    public RectTransform Bat;
    public UnityEvent OnTimerHasFinished;
    public float timerLength = 3;
    public float t;

    public void mouseJustEneteredImage()
    {
        Debug.Log("mouse just entered me");
        Bat.localScale = Vector3.one * 1.2f;
    }
    public void mouseJustLeftImage()
    {
        Debug.Log("mouse just left me");
        Bat.localScale = Vector3.one;
    }
}

