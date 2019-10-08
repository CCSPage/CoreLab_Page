using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{

    public Sprite sprite1; 
    public Sprite sprite2; 
    private SpriteRenderer spriteRenderer;

    Rigidbody2D rb;

    bool canJump;
    int numJumpsAllowed;
    int numJumps;

    float horz;
    public float speed;

 

    // Start is called before the first frame update
    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); 
        rb = GetComponent<Rigidbody2D>();
        canJump = true;
        numJumpsAllowed = 1;
    }

    // Update is called once per frame
    void Update()
    {
        horz = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horz * speed * Time.deltaTime);

        if (canJump)
        {
            if (numJumps < numJumpsAllowed)
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    rb.AddForce(Vector2.up * 11, ForceMode2D.Impulse);
                    numJumps++;
                    spriteRenderer.sprite = sprite2;
                }
            }
            else
            {
                canJump = false;
               
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "ground")
        {
            canJump = true;
            numJumps = 0;
            spriteRenderer.sprite = sprite1;
        }
      

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "cheese")
        {
            Destroy(collision.gameObject);
            GameManagement.Pono.score++;
            GameManagement.Pono.UpdateScore();
        }

    }

}
