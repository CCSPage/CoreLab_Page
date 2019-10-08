using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagement : MonoBehaviour
{
    public static GameManagement Pono; //singleton

    private void Awake()
    {
        if (Pono == null)
        {
            Pono = this;
            DontDestroyOnLoad(this);
        }
        else if (Pono != this)
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public int score;

    public void UpdateScore()
    {
        UIManager.Score.ShowNewScore(score);
    }
}
