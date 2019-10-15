using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class linkingSlider : MonoBehaviour
{
    public Slider slider;
    public Text buttonText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(slider.value >= 0 && slider.value < 1)
        {
            buttonText.text = "(1)choose a number (2)click me";

            Debug.Log("Instructions");
        }
        if (slider.value >= 1 && slider.value < 2)
        {
            buttonText.text = "1";
            Debug.Log("SET SPEED TO 1");
        }
        if (slider.value >= 2 && slider.value < 3)
        {
            buttonText.text = "2";
            Debug.Log("SET SPEED TO 2");
        }
        if (slider.value >= 3 && slider.value < 4)
        {
            buttonText.text = "3";
            Debug.Log("SET SPEED TO 3");
        }
        if (slider.value >= 4 && slider.value < 5)
        {
            buttonText.text = "4";
            Debug.Log("SET SPEED TO 4");
        }
        if (slider.value >= 5)
        {
            buttonText.text = "5";
            Debug.Log("SET SPEED TO 5");
        }
    }
}
