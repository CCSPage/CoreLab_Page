using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class squareFollow : MonoBehaviour
{
    private Vector3 mousePosition;
    private Rigidbody2D rb;
    private Vector2 direction;
    public float moveSpeed;


    public Text text;
    float timeLeft = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        direction = (mousePosition - transform.position).normalized;
        rb.velocity = new Vector2(direction.x * moveSpeed, direction.y * moveSpeed);

    }

    private void OnCollisionStay2D(Collision2D collision)

    {
        if (collision.gameObject.tag == "circle")
        {
            Debug.Log("YESSSSS");
            CountDown();
        } else
        {
            text.text = ("0");
        }
    }



    public void CountDown()
    {
         

    text.text = timeLeft.ToString("f"); 
            timeLeft -= Time.deltaTime;
        if (timeLeft < 0)
        {
            int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
            
                SceneManager.LoadScene(currentSceneIndex + 1);

            
        }
    }


}