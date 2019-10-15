using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class animationspeedslider : MonoBehaviour
{

    public Slider s;
    Animator anim;
    float sliderval;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        sliderval = s.value;
        anim.speed = sliderval;
    }
    public void AnimationEvent()
    {
        Debug.Log("I'm dizzy");
    }
}
