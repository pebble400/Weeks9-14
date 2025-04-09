using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimerBell : MonoBehaviour
{

    public MouseOverButton cooking;
    // Start is called before the first frame update
    void Start()
    {
        cooking.isCooked.AddListener(DingDing);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void DingDing()
    {

    }
}
