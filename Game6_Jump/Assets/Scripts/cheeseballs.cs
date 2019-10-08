using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cheeseballs : MonoBehaviour
{
    public GameObject cheeseball;
    float timer;
    public float interval;


    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer >= interval)
        {

            GameObject p;
            p = Instantiate(cheeseball, new Vector3(Random.Range(-6, 6), Random.Range(-1.3f, .9f), 0), Quaternion.identity);
           
            timer = 0;
      
        }
    }

  
}
