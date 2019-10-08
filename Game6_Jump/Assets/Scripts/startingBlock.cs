using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startingBlock : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Destroy(this.gameObject);
        }
    }
}
