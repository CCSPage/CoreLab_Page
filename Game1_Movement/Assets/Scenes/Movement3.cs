﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3 : MonoBehaviour
{
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
      //  transform.position = new Vector2(2, 0);

        speed = 149;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector2(1, 0) * Time.deltaTime * speed);

    }
}
