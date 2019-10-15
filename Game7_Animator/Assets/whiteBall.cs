using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteBall : MonoBehaviour
{
    public GameObject blackBall;
    public GameObject blackWin;
   // public GameObject whiteWin;

  
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -6)
        {
            Destroy(this.gameObject);
       //     Destroy(whiteWin);
            Instantiate(blackBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            //  Instantiate(blackWin, new Vector2(Random.Range(-2.95f,2.95f), -2.42f), Quaternion.identity);
            Points.scoreValue-=1;
        }
        //if (transform.position.x <= -4.6 || transform.position.x >= 4.6)
        //{
        //    Destroy(this.gameObject);
        //    Instantiate(blackBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
        //}

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "whiteBall")
        {
            Destroy(this.gameObject);
           // Destroy(whiteWin);
            Instantiate(blackBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            // Instantiate(blackWin, new Vector2(Random.Range(-2.95f, 2.95f), -2.42f), Quaternion.identity);
            Points.scoreValue+=1;
        }
        if (collision.gameObject.tag == "blackBall")
        {
            Destroy(this.gameObject);
            // Destroy(whiteWin);
            Instantiate(blackBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            // Instantiate(blackWin, new Vector2(Random.Range(-2.95f, 2.95f), -2.42f), Quaternion.identity);
            Points.scoreValue-=1;
        }

    }
}
