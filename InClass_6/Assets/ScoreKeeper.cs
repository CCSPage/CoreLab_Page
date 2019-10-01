using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreKeeper : MonoBehaviour
{
    int score = 0;
    public Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
   
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void IncreaseScore()
    {
        score ++;
        UpdatescoreText(score);
        Debug.Log(score);
    }

    public void DecreaseScore()
    {
        score--;
        UpdatescoreText(score);
        Debug.Log(score);
    }

    void UpdatescoreText(int s) {

    scoreText.text = s.ToString();
    }
    
}
