using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScrollViewExample : MonoBehaviour
{
    public ScrollRect scrollRect;
    // Start is called before the first frame update
    void Start()
    {
        scrollRect.verticalNormalizedPosition = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}