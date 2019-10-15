using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Balls : MonoBehaviour
{
    public GameObject whiteBall;


    // Start is called before the first frame update
    void Start()
    {
        Instantiate(whiteBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);

    
       
    }

    // Update is called once per frame
    void Update()
    {

    

    }
}

