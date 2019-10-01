using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Move1 : MonoBehaviour
{
    float horz;
    float vert;
    Rigidbody2D rb;
    public float forceAmount;
    public float pushamount;


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

        //Debug.Log(horz + "  " + vert);

        transform.Translate(horz * Time.deltaTime, vert * Time.deltaTime, 0);
        rb.AddForce(new Vector2(horz, vert) * forceAmount);

        if (transform.position.y <= -5)
        {
            SceneManager.LoadScene(2);

        }



    }
}
