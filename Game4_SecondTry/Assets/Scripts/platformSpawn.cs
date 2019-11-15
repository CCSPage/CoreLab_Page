using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platformSpawn : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        transform.Translate(Vector2.down * 3 * Time.deltaTime);
        if (transform.position.y <= -6)
        {
            Destroy(this.gameObject);

        }
     
    }
}