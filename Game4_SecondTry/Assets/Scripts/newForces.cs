using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class newForces : MonoBehaviour
{
    float horz;
    float vert;
    Rigidbody2D rb;
    public float forceAmount;

    // Start is called before the first frame update
    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        vert = Input.GetAxis("Vertical");
        rb.AddForce(new Vector2(-horz, vert) * forceAmount);

    }
}
