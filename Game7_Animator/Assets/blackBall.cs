using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackBall : MonoBehaviour
{ 
 public GameObject whiteBall;
 //public GameObject whiteWin;
// public GameObject blackWin;

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
          //  Destroy(blackWin);
            Instantiate(whiteBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            Points.scoreValue-=1;
       // Instantiate(whiteWin, new Vector2(Random.Range(-2.95f, 2.95f), -2.42f), Quaternion.identity);

        }
    //if (transform.position.x <= -4.6 || transform.position.x >= 4.6)
    //{
    //    Destroy(this.gameObject);
    //    Instantiate(whiteBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
    //}
}

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "blackBall")
        {
            Destroy(this.gameObject);
           // Destroy(blackWin);
            Instantiate(whiteBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            //Instantiate(whiteWin, new Vector2(Random.Range(-2.95f, 2.95f), -2.42f), Quaternion.identity);
            Points.scoreValue+=1;
        }

        if (collision.gameObject.tag == "whiteBall")
        {
            Destroy(this.gameObject);
            // Destroy(blackWin);
            Instantiate(whiteBall, new Vector2(Random.Range(-3, 3), 4), Quaternion.identity);
            //Instantiate(whiteWin, new Vector2(Random.Range(-2.95f, 2.95f), -2.42f), Quaternion.identity);
            Points.scoreValue-=1;
        }

    }
}
