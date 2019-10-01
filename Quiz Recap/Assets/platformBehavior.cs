using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformBehavior : MonoBehaviour
{
    SpriteRenderer sr;
    float rotVal;
    Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        sr = GetComponent<SpriteRenderer>();
        sr.color = Random.ColorHSV(0,1,1,1,0.5f,1);
    }

    // Update is called once per frame
    void Update()
    {
        pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.eulerAngles = new Vector3(0, 0, pos.x * -3); //found by googling "unity degree rotation"

        if (Input.GetKeyDown(KeyCode.Space))
        {
            sr.color = Random.ColorHSV(0, 1, 1, 1, 0.5f, 1);
        }
    }
}
