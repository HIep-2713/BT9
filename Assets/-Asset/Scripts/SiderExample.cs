using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SiderExample : MonoBehaviour
{
    public Slider MySlider;
    // Start is called before the first frame update
    public void OnSliderValueChanger(float value)
    {
        Debug.Log("Slider:" + value);
    }
    

    // Update is called once per frame
    void Update()
    {
        
    }
}
