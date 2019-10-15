using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winMoves : MonoBehaviour
{
    Rigidbody2D rb;

    float horz;
    public float speed;



    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);
    }
}