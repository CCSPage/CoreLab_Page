using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lose : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= -5.5f)
        {
            transform.position = new Vector2(0, 0);

            penalties.scoreValue += 1;
            points.scoreValue = 0;
            Application.LoadLevel(0); //https://answers.unity.com/questions/1253831/how-to-restart-the-game-2.html

        }

        
    }
}
