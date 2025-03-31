using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverButton : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;
    public float cookTime;


    IEnumerator FoodIsCooking()
    {
        cookTime = 1;
        while (cookTime < 1)
        {
            cookTime += Time.deltaTime;
            yield return null;
        }
        
    }

    public void MouseIsOverUs()
    {
        image.sprite = highlight;
        StartCoroutine(FoodIsCooking());

    }

    public void MouseNotOverUs()
    {
        image.sprite = normal;
    }
}
