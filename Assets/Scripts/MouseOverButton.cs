using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class MouseOverButton : MonoBehaviour
{
    public UnityEvent isCooked;
    public Slider slider;//Made this pubic so that I can reference it in the inspector
    public float t;
    public Image image;

    public Sprite highlight;//Event trigger to swap sprites, this is the highlighted state of the button
    public Sprite normal;//normal state
    public float cookTime = 5;//Time it takes to "cook" the food
    IEnumerator FoodIsCooking()//Start of Coroutine
    {
        
        cookTime = 0;//Setting the value of cook time
        while (cookTime < 1)//if cook time is less than one then trigger the function bellow
        {
            t += Time.deltaTime;
            slider.value = t % slider.maxValue;//increase the slider value
            yield return null;
        }
        
    }
    void Update()
    {
        if (t >= 1)
        {
            isCooked.Invoke();//triggers the message in console
        }
    }

    public void MouseIsOverUs()//Swap sprite and start the Coroutine
    {
        image.sprite = highlight;
        StartCoroutine(FoodIsCooking());

    }
    public void FoodIsCooked()
    {
        Debug.Log("Food is done.");//outputs a message in the console 

    }

    public void MouseNotOverUs()
    {
        image.sprite = normal;
    }
}
