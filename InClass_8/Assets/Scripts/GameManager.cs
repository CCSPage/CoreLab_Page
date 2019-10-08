using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Pono; //singleton

    private void Awake(){
        if (Pono == null)
        {
            Pono = this;
            DontDestroyOnLoad(this);
        } else if (Pono != this)
        {
            Destroy(gameObject);
        }
      }


    public int score;

    public void UpdateScore()
    {
        UIManager.Laura.ShowNewScore(score);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (score == 3)
        {
            UpdateScore();
            score = 4;
            SceneManager.LoadScene(2);
        }
    }

  public void LoseGame()
    {
        SceneManager.LoadScene(3);
        score = 0;
        UpdateScore();
    }
}
