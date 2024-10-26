using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ImageExample : MonoBehaviour
{

    public Image myImage;
    public Sprite newSprite;
    void Start()
    {
        myImage.sprite = newSprite;
    }
}