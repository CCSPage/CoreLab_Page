using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Movement2 : MonoBehaviour
{
    public float speed;
    public GameObject square;
    // Start is called before the first frame update
    void Start()
    {
        speed = 5;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector2 (Mathf.Sin(Time.time),1);
        transform.Rotate(0,0,1*speed);

        Vector2 dirBtwnSquares = square.transform.position - transform.position;
        float angle = Mathf.Atan2(dirBtwnSquares.y, dirBtwnSquares.x)* Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);

        transform.Translate (new Vector2 (5,0) * Time.deltaTime);
        if (transform.position.x >= 16)
        {
            transform.position = new Vector2(-18, transform.position.y);
        }

    }

}
