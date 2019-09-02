using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    public float speed;
    //public GameObject One;

    // Start is called before the first frame update
    void Start()
    {
      //  transform.position = new Vector2(0, 0);
        //One.transform.position = new Vector2(-4, 0);
        speed = 150;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector2(1, 0) * Time.deltaTime * speed);
       // One.transform.Rotate(new Vector2(1, 0) * Time.deltaTime * speed);
    }
}
