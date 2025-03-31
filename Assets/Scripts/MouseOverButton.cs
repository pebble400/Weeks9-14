using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MouseOverButton : MonoBehaviour
{
    public Image image;

    public Sprite highlight;
    public Sprite normal;
    public float cookTime = 0f;

    public void MouseIsOverUs()
    {
        image.sprite = highlight;
        cookTime++;
    }

    public void MouseNotOverUs()
    {
        image.sprite = normal;
    }
}
