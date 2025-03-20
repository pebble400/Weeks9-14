using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoxyJumpscare : MonoBehaviour
{
    public AnimationCurve curve;
    [Range(0, 1)]
    public float t;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
    IEnumerator FoxyJumpScare()
    {
        t = 0;
        while(t < 4)
        {
            t += Time.deltaTime;
            Vector2 pos = transform.localScale;
            pos.x = curve.Evaluate(t);
            pos.y = curve.Evaluate(t);

            transform.localScale = pos;
        }
        
    }
}
