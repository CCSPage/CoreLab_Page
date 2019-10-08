using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{

    public static UIManager Score;

    public Text Scoretext;
    // Start is called before the first frame update

   

    private void Awake()
    {
        if(Score = null)
        {
            Score = this;
        }else if(Score != this){
            Destroy(gameObject);
        }
    }

    public void ShowNewScore(int score)
    {
        Scoretext.text = score.ToString();
    }
}
