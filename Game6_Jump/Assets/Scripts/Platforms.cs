using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platforms : MonoBehaviour
{
    public GameObject platform;
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
            p = Instantiate(platform, new Vector3(6, Random.Range(-2.3f,.7f),0), Quaternion.identity);

            timer = 0;

        }
    }
}
