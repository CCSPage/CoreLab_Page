using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class movement3 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        speed = 2;
    }

    // Update is called once per frame
    void Update()
    {

        transform.Translate(new Vector2(-5, 0) * Time.deltaTime*speed);
        if (transform.position.x <= -8)
        {
            transform.position = new Vector2(8, transform.position.y);
        }

    }

}
