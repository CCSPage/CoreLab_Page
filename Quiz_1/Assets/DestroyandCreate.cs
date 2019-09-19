using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyandCreate : MonoBehaviour
{
  
    public GameObject ball;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {


        transform.Translate(Vector2.down*.01f);
        if (transform.position.y <= -6)
        {
           transform.position = new Vector2(Random.Range(-8.0f, 7.0f), 4); //I'M HAVING SO MUCH TROUBLE SLOWING IT DOWN...I tried figuring out how to instantiate a new prefab once the other one was destroyed but couldn't get it so I ended up having to wrap the ball but it speeds up so much upon reentry. 

            //  Destroy(this.gameObject);
          
         
        }

  

    }
}
