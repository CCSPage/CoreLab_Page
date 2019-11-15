using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class points : MonoBehaviour
{
    public static int scoreValue = 0;
    Text score;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = "Score: " + scoreValue;

        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
      
        if (scoreValue >= 20)
        {
            SceneManager.LoadScene(currentSceneIndex + 1);
            scoreValue = 0;
        }

    }

}
