using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Animations : MonoBehaviour
{

    public Slider yummy;
    public Slider jumpy;
    public Slider tickles;
    public Slider sleepy;

    public float maxslider;

    // Start is called before the first frame update
    void Start()
    {
      
        maxslider = .75f;
    }

    // Update is called once per frame
    void Update()
    {

        if (Points.scoreValue >= 8)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;


            SceneManager.LoadScene(currentSceneIndex + 1);
            Points.scoreValue = 0;
        }
            
    }



    public void Addyummy()
    {
        yummy.value += 0.1f;
        if (yummy.value >= maxslider)
        {
            Points.scoreValue += 1;
            yummy.value = 0f;
        }
    }
        public void Addjumpy() {
            jumpy.value += 0.1f;
            if (jumpy.value >= maxslider)
            {
                Points.scoreValue += 1;
                jumpy.value = 0f;
            }
        }

    public void Addtickles() {
        tickles.value += 0.1f;
        if (tickles.value >= maxslider)
        {
            Points.scoreValue += 1;
            tickles.value = 0f;
        }
    }
    public void Addsleepy() { 
        sleepy.value += 0.1f;
        if (sleepy.value >= maxslider)
        {
            Points.scoreValue += 1;
            sleepy.value = 0f;
        }
    }
  
    }

