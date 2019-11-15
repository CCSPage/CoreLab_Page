using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platforms : MonoBehaviour
{
    public GameObject platform;
    //public GameObject Coin;
    float timer;
    public float interval;
    //private float InstantiationTimer = 2f;

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
            p = Instantiate(platform, new Vector3(Random.Range(-1.8f, 2.6f), 5f, 0), Quaternion.identity);
            timer = 0;

        }
        //CreatePrefab();
    }
    //void CreatePrefab()
    //{
    //    InstantiationTimer -= Time.deltaTime;
    //    if (InstantiationTimer <= 0)
    //    {
    //        Instantiate(Coin, new Vector3(Random.Range(-2,2),Random.Range(-2,5),0), Quaternion.identity);
    //        InstantiationTimer = 2f;
    //    }
    //}
}
